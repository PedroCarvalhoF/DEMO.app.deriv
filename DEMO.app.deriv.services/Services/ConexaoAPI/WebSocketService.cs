using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public class WebSocketService : IDisposable
    {
        private readonly ClientWebSocket _webSocket;
        private readonly string _uri;
        private readonly CancellationTokenSource _cts;

        public WebSocketService(string appId)
        {
            _uri = $"wss://ws.derivws.com/websockets/v3?app_id={appId}";
            _webSocket = new ClientWebSocket();
            _cts = new CancellationTokenSource();
        }
        //criar Conexao
        public async Task ConnectAsync()
        {
            if (_webSocket.State != WebSocketState.Open)
            {
                Console.WriteLine("Conectando ao WebSocket...");
                await _webSocket.ConnectAsync(new Uri(_uri), _cts.Token);
                Console.WriteLine("Conexão estabelecida.");
            }
        }
        public bool GetStatusConexaoWebSockets()
        {
            if (_webSocket.State == WebSocketState.Open)
                return true;

            return false;
        }


        // Método para enviar mensagens
        public async Task SendMessageAsync(object message)
        {
            if (_webSocket.State == WebSocketState.Open)
            {
                // Verificar se o objeto é uma string JSON
                string jsonMessage = message as string;

                // Se já for uma string JSON válida, use-a diretamente
                if (jsonMessage != null)
                {
                    Console.WriteLine($"Mensagem enviada: {jsonMessage}");
                }
                else
                {
                    // Caso contrário, serialize o objeto
                    jsonMessage = JsonSerializer.Serialize(message);
                    Console.WriteLine($"Mensagem enviada: {jsonMessage}");
                }

                var bytes = Encoding.UTF8.GetBytes(jsonMessage);
                await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            else
            {
                Console.WriteLine("Conexão WebSocket não está aberta.");
            }
        }

        //envia mensage e ja realizada a leitura
        public async Task<string> SendAndReceiveMessageAsync(object message)
        {
            if (_webSocket.State != WebSocketState.Open)
            {
                throw new InvalidOperationException("Conexão WebSocket não está aberta.");
            }

            // Enviar a mensagem
            await SendMessageAsync(message);

            // Receber a resposta
            string response = await ReceiveMessageAsync();
            Console.WriteLine($"Resposta recebida: {response}");

            return response;
        }
        // Método para receber mensagens
        public async Task<string> ReceiveMessageAsync()
        {
            var buffer = new byte[8192];
            var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cts.Token);
            return Encoding.UTF8.GetString(buffer, 0, result.Count);
        }
        // Dispose
        public void Dispose()
        {
            _webSocket?.Dispose();
            _cts?.Dispose();
        }
    }
}
