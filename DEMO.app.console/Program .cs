using System.Net.WebSockets;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace DEMO.app.console
{
    internal class Program
    {
        private static readonly Uri uri = new Uri("wss://ws.derivws.com/websockets/v3?app_id=66069"); // Replace with your app_id if needed

        public static async Task Main(string[] args)
        {
            using (ClientWebSocket webSocket = new ClientWebSocket())
            {
                Console.WriteLine("Attempting to connect to WebSocket...");

                await webSocket.ConnectAsync(uri, CancellationToken.None);
                Console.WriteLine("[status] WebSocket connection established.");

                // Send contracts for symbol request
                await SendContractsForSymbolRequest(webSocket);

                // Handle responses from the server
                await HandleResponses(webSocket);
            }
        }

        private static async Task SendContractsForSymbolRequest(ClientWebSocket webSocket)
        {
            var contractsForSymbolRequest = new
            {
                contracts_for = "R_50",
                currency = "USD",
                landing_company = "svg",
                product_type = "basic"
            };

            string requestJson = JsonSerializer.Serialize(contractsForSymbolRequest);
            var bytes = Encoding.UTF8.GetBytes(requestJson);
            await webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
            Console.WriteLine("[request] Contracts for symbol request sent.");
        }

        private static async Task HandleResponses(ClientWebSocket webSocket)
        {
            var buffer = new byte[8192];
            var messageBuilder = new StringBuilder();

            while (webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    Console.WriteLine("WebSocket connection closed by server.");
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
                    break;
                }

                messageBuilder.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));

                if (result.EndOfMessage)
                {
                    try
                    {
                        var data = JsonDocument.Parse(messageBuilder.ToString()).RootElement;
                        if (data.TryGetProperty("error", out var error))
                        {
                            Console.WriteLine($"[Error] {error.GetProperty("message").GetString()}");
                            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing due to error", CancellationToken.None);
                            break;
                        }

                        if (data.TryGetProperty("msg_type", out var msgType) && msgType.GetString() == "contracts_for")
                        {
                            Console.WriteLine("Contracts for Symbol (R_50):");
                            foreach (var contract in data.GetProperty("contracts_for").GetProperty("available").EnumerateArray())
                            {
                                Console.WriteLine($"  - Contract Type: {contract.GetProperty("contract_type").GetString()}");
                                Console.WriteLine($"    - Display Name: {contract.GetProperty("contract_display").GetString()}");
                                Console.WriteLine($"    - Category: {contract.GetProperty("contract_category_display").GetString()}");
                                Console.WriteLine($"    - Market: {contract.GetProperty("market").GetString()}");
                                Console.WriteLine($"    - Submarket: {contract.GetProperty("submarket").GetString()}");
                                Console.WriteLine($"    - Expiry Type: {contract.GetProperty("expiry_type").GetString()}");

                                // Check for optional properties with safe access
                                Console.WriteLine($"    - Min Duration: {(contract.TryGetProperty("min_contract_duration", out var minDuration) ? minDuration.GetString() : "N/A")}");
                                Console.WriteLine($"    - Max Duration: {(contract.TryGetProperty("max_contract_duration", out var maxDuration) ? maxDuration.GetString() : "N/A")}");
                                Console.WriteLine($"    - Barrier: {(contract.TryGetProperty("barrier", out var barrier) ? barrier.GetString() : "N/A")}");
                                Console.WriteLine($"    - Sentiment: {(contract.TryGetProperty("sentiment", out var sentiment) ? sentiment.GetString() : "N/A")}");
                                Console.WriteLine("    --------------------");
                            }
                        }

                        messageBuilder.Clear();
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"[Error] Failed to parse JSON message: {ex.Message}");
                    }
                }
            }
        }


    }

}

