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

        public async Task ObserveTicksAsync(string indice, CancellationToken cancellationToken, Action<double> onTickReceived)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        // Conecta ou reconecta o WebSocket
                        if (!ConexaoOpem)
                        {
                            await CriarConexao(indice, cancellationToken, onTickReceived);
                        }

                        while (webSocket.State == WebSocketState.Open || webSocket.State == WebSocketState.Closed)
                        {
                            try
                            {
                                if (webSocket.State == WebSocketState.Closed)
                                {
                                    Console.WriteLine("WebSocket fechado.");
                                    await ReconectarConexao(indice, cancellationToken, onTickReceived);
                                    Console.WriteLine("Atualizando variável para enviar novamente o comando.");
                                    commandEnviado = false;
                                }

                                if (!commandEnviado)
                                {
                                    // Envia o comando de assinatura se ainda não foi enviado
                                    var subscriptionRequest = new { ticks = indice, subscribe = 1 };
                                    string requestMessage = JsonSerializer.Serialize(subscriptionRequest);
                                    var requestBytes = Encoding.UTF8.GetBytes(requestMessage);
                                    var requestSegment = new ArraySegment<byte>(requestBytes);

                                    await webSocket.SendAsync(requestSegment, WebSocketMessageType.Text, true, cancellationToken);
                                    commandEnviado = true;
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
                                        onTickReceived?.Invoke(quote);
                                    }
                                }
                            }
                            catch (WebSocketException ex)
                            {
                                Console.WriteLine($"Erro WebSocket: {ex.Message}. Tentando reconectar...");
                                await Task.Delay(1000, cancellationToken); // Pequeno atraso antes de tentar novamente
                                continue;  // Isso vai voltar para o topo do loop externo, recomeçando a execução
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro não esperado: {ex.Message}");
                        await Task.Delay(1000, cancellationToken); // Espera um tempo e tenta novamente
                        continue; // Volta para o início do loop principal, reiniciando o processo de conexão
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro geral: {ex.Message}");
            }
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
