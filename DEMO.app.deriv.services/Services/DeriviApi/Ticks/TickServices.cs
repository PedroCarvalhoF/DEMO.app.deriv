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

        public async Task ObserveTicksAsync(string indice, CancellationToken cancellationToken, Action<double> onTickReceived)
        {
            using (ClientWebSocket webSocket = new ClientWebSocket())
            {
                Console.WriteLine("Connecting to WebSocket...");
                await webSocket.ConnectAsync(uri, cancellationToken);
                Console.WriteLine("[status] WebSocket connection established.");

                // Assinar o índice
                var subscriptionRequest = new { ticks = indice, subscribe = 1 };
                string requestMessage = JsonSerializer.Serialize(subscriptionRequest);
                var requestBytes = Encoding.UTF8.GetBytes(requestMessage);
                var requestSegment = new ArraySegment<byte>(requestBytes);

                await webSocket.SendAsync(requestSegment, WebSocketMessageType.Text, true, cancellationToken);


                // Processar mensagens recebidas
                var buffer = new byte[8192];
                while (!cancellationToken.IsCancellationRequested && webSocket.State == WebSocketState.Open)
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("WebSocket connection closed by server.");
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);

                    using (JsonDocument document = JsonDocument.Parse(message))
                    {
                        JsonElement root = document.RootElement;

                        if (root.TryGetProperty("tick", out JsonElement tickElement) &&
                            tickElement.TryGetProperty("quote", out JsonElement quoteElement))
                        {
                            double quote = quoteElement.GetDouble();

                            // Executa a ação para atualizar a interface
                            onTickReceived?.Invoke(quote);
                        }
                    }
                }
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
