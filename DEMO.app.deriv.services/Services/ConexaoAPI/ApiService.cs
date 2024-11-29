using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public class ApiService : IApiService
    {
        private static readonly Uri WebSocketUri = new Uri("wss://ws.derivws.com/websockets/v3?app_id=66069");
        private const string AuthorizationToken = "NIyfyeoQZw4WhRC"; // Substitua pelo seu token real
        public async Task<string> ConectWebSockets()
        {
            string app_id = "1089"; // Replace with your app_id.
            string uri = $"wss://ws.derivws.com/websockets/v3?app_id={app_id}"; // WebSocket URI with the app_id

            using (ClientWebSocket webSocket = new ClientWebSocket())
            {
                try
                {
                    // Connect to the WebSocket server
                    await webSocket.ConnectAsync(WebSocketUri, CancellationToken.None);
                    Console.WriteLine("[open] Connection established");

                    // Send a ping message to the server
                    string sendMessage = "{\"ping\": 1}"; // Prepare the ping message in JSON format
                    ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(sendMessage));
                    await webSocket.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
                    Console.WriteLine("Sending to server");

                    // Receive message from the server
                    var buffer = new byte[1024];
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    string response = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Close connection", CancellationToken.None);
                    return response;

                    //Console.WriteLine("[message] Data received from server: " + response);

                    //// Close the WebSocket connection cleanly

                    //Console.WriteLine("[close] Connection closed cleanly");
                }
                catch (WebSocketException e)
                {
                    Console.WriteLine("[error] WebSocket error: " + e.Message);
                    throw new Exception(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("[error] " + e.Message);
                    throw new Exception(e.Message);
                }
                finally
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Close connection", CancellationToken.None);
                }
            }
        }
    }
}
