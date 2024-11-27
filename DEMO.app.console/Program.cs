using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DEMO.app.console
{
    internal class Program
    {
        private static readonly Uri WebSocketUri = new Uri("wss://ws.derivws.com/websockets/v3?app_id=1089");
      //  private const string AuthorizationToken = "***********QVoc"; // Substitua pelo seu token real
        private static readonly CancellationTokenSource Cts = new CancellationTokenSource();
        static async Task Main(string[] args)
        {
            using (var webSocket = new ClientWebSocket())
            {
                try
                {
                    Console.WriteLine("Attempting to connect to WebSocket...");
                    await webSocket.ConnectAsync(WebSocketUri, Cts.Token);
                     Thread.Sleep(5000);

                    if (webSocket.State == WebSocketState.Open)
                    {
                        Console.WriteLine("[status] WebSocket connection established.");

                        // Send authorization
                        //await SendAuthorizationAsync(webSocket);

                        // Send contracts for symbol request
                        await SendContractsForSymbolRequestAsync(webSocket);

                        // Handle server responses
                        await HandleResponsesAsync(webSocket);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("[Error] WebSocket is not open.");
                        Console.ReadLine();
                    }
                }
                catch (WebSocketException ex)
                {
                    Console.WriteLine($"[Error] WebSocket error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Unexpected error: {ex.Message}");
                }
                finally
                {
                    if (webSocket.State == WebSocketState.Open || webSocket.State == WebSocketState.CloseReceived)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", Cts.Token);
                    }

                    Console.ReadLine();
                }
            }


        }
        //private static async Task SendAuthorizationAsync(ClientWebSocket webSocket)
        //{
        //    var authRequest = new { authorize = AuthorizationToken };
        //    string requestJson = JsonSerializer.Serialize(authRequest);

        //    await SendMessageAsync(webSocket, requestJson);
        //    Console.WriteLine("[request] Authorization sent.");
        //}
        private static async Task SendContractsForSymbolRequestAsync(ClientWebSocket webSocket)
        {
            var contractsForSymbolRequest = new
            {
                contracts_for = "R_50",
                currency = "USD",
                landing_company = "svg",
                product_type = "basic"
            };

            string requestJson = JsonSerializer.Serialize(contractsForSymbolRequest);

            await SendMessageAsync(webSocket, requestJson);
            Console.WriteLine("[request] Contracts for symbol request sent.");
        }
        private static async Task HandleResponsesAsync(ClientWebSocket webSocket)
        {
            var buffer = new byte[8192];
            var messageBuilder = new StringBuilder();

            while (webSocket.State == WebSocketState.Open)
            {
                try
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), Cts.Token);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("WebSocket connection closed by server.");
                        break;
                    }

                    messageBuilder.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));

                    if (result.EndOfMessage)
                    {
                        ProcessMessage(messageBuilder.ToString());
                        messageBuilder.Clear();
                    }
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("[Info] Operation cancelled.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Failed to receive message: {ex.Message}");
                    break;
                }
            }
        }
        private static void ProcessMessage(string message)
        {
            try
            {
                var data = JsonDocument.Parse(message).RootElement;

                if (data.TryGetProperty("error", out var error))
                {
                    Console.WriteLine($"[Error] {error.GetProperty("message").GetString()}");
                    return;
                }

                if (data.TryGetProperty("msg_type", out var msgType) && msgType.GetString() == "contracts_for")
                {
                    Console.WriteLine("Contracts for Symbol (R_50):");
                    foreach (var contract in data.GetProperty("contracts_for").GetProperty("available").EnumerateArray())
                    {
                        Console.WriteLine($"  - {contract.GetProperty("contract_display").GetString()}");
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"[Error] Failed to parse JSON message: {ex.Message}");
            }
        }
        private static async Task SendMessageAsync(ClientWebSocket webSocket, string message)
        {
            var bytes = Encoding.UTF8.GetBytes(message);
            await webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, Cts.Token);
        }


    }
}