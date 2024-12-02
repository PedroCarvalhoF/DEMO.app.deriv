using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Ticks
{
    public class TickServices : ITickServices
    {
        private static readonly Uri uri = new Uri("wss://ws.derivws.com/websockets/v3?app_id=66069");
        ClientWebSocket webSocket = new ClientWebSocket();
        bool commandEnviado = false;

        bool ConexaoOpem => webSocket.State == WebSocketState.Open;
        private async Task<bool> CriarConexao(string indice, CancellationToken cancellationToken, Action<double> onTickReceived)
        {
            try
            {
                if (webSocket.State != WebSocketState.Open)
                {
                    webSocket = null;
                    webSocket = new ClientWebSocket();
                    Console.WriteLine("Conectando WebSocket....");
                    await webSocket.ConnectAsync(uri, cancellationToken);
                    Console.WriteLine("WebSocket connection established.");

                    if (webSocket.State == WebSocketState.Open)
                        return true;

                    return false;
                }

                return false;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private async Task<bool> ReconectarConexao(string indice, CancellationToken cancellationToken, Action<double> onTickReceived)
        {
            try
            {
                webSocket = null;
                webSocket = new ClientWebSocket();
                Console.WriteLine("Reconectando WebSocket....");
                await webSocket.ConnectAsync(uri, cancellationToken);
                Console.WriteLine("Conexão restabelecida.");

                if (webSocket.State == WebSocketState.Open)
                    return true;

                return false;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void ObserverTickCancelar() => observarTickEnable = false;
        private bool observarTickEnable = true;
        private double _tick = 0;
        public double GetTick() => _tick;
        public async Task ObserveTicksAsync(string indice, CancellationToken cancellationToken, Action<double> onTickReceived)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    while (webSocket.State != WebSocketState.Open)
                    {
                        Console.WriteLine("WebSocket fechado.");
                        await ReconectarConexao(indice, cancellationToken, onTickReceived);
                        commandEnviado = false;
                    }

                    if (!commandEnviado)
                    {
                        // Envia o comando de assinatura se ainda não foi enviado
                        Console.WriteLine("Enviando requisição para receber Tick.");
                        var subscriptionRequest = new { ticks = indice, subscribe = 1 };
                        string requestMessage = JsonSerializer.Serialize(subscriptionRequest);
                        var requestBytes = Encoding.UTF8.GetBytes(requestMessage);
                        var requestSegment = new ArraySegment<byte>(requestBytes);

                        await webSocket.SendAsync(requestSegment, WebSocketMessageType.Text, true, cancellationToken);
                        commandEnviado = true;
                        Console.WriteLine($"Requisição enviada: {requestMessage}");
                    }

                    var buffer = new byte[8192];

                    // Recebe mensagens do WebSocket
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("WebSocket connection closed by server.");
                        break; // Sai do loop para reconectar
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);

                    // Processa a mensagem de tick
                    using (JsonDocument document = JsonDocument.Parse(message))
                    {
                        JsonElement root = document.RootElement;

                        if (root.TryGetProperty("tick", out JsonElement tickElement) &&
                            tickElement.TryGetProperty("quote", out JsonElement quoteElement))
                        {
                            double quote = quoteElement.GetDouble();
                            Console.WriteLine($"Tick: {quote}");
                            _tick = quote;
                            onTickReceived?.Invoke(quote);
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Observação de ticks foi cancelada.");
                    break;
                }
                catch (WebSocketException ex)
                {
                    commandEnviado = false;
                    Console.WriteLine($"Erro WebSocket: {ex.Message}. Tentando reconectar...");
                }
                catch (Exception ex)
                {
                    commandEnviado = false;
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }

            Console.WriteLine("Observação parada.");
        }

        private async Task ReceiveTicksAsync(ClientWebSocket webSocket, CancellationToken cancellationToken)
        {
            var buffer = new byte[8192];

            while (!cancellationToken.IsCancellationRequested && webSocket.State == WebSocketState.Open)
            {
                try
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("WebSocket connection closed by server.");
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", cancellationToken);
                        break;
                    }

                    // Processar a mensagem recebida
                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    HandleTickMessage(message);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Observação de ticks cancelada.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error receiving ticks: {ex.Message}");
                }
            }
        }

        private void HandleTickMessage(string message)
        {
            try
            {
                using (JsonDocument document = JsonDocument.Parse(message))
                {
                    JsonElement root = document.RootElement;

                    if (root.TryGetProperty("tick", out JsonElement tickElement))
                    {
                        if (tickElement.TryGetProperty("quote", out JsonElement quoteElement))
                        {
                            double quote = quoteElement.GetDouble();
                            Console.WriteLine($"Tick received: {quote}");
                        }
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Invalid JSON format: {ex.Message}");
            }
        }
    }
}
