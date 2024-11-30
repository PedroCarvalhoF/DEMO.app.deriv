using System;
using System.IO;
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
                await ConnectAsync();
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
            const int bufferSize = 1024; // Tamanho do buffer para leitura
            var buffer = new ArraySegment<byte>(new byte[bufferSize]);

            // Substituindo o uso do 'using' por uma declaração tradicional
            var memoryStream = new MemoryStream();
            WebSocketReceiveResult result;

            try
            {
                // Recebe mensagens do WebSocket
                do
                {
                    result = await _webSocket.ReceiveAsync(buffer, CancellationToken.None);

                    // Se o servidor enviar um fechamento da conexão
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Conexão encerrada pelo servidor", CancellationToken.None);
                        Console.WriteLine("Conexão encerrada pelo servidor.");
                        return string.Empty;
                    }

                    // Escreve os dados recebidos no MemoryStream
                    memoryStream.Write(buffer.Array, buffer.Offset, result.Count);

                } while (!result.EndOfMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao receber a mensagem: {ex.Message}");
                return string.Empty;
            }
            finally
            {
                // Garante que o Dispose seja chamado para liberar recursos
                //memoryStream.Dispose();
            }

            // Faz a leitura do MemoryStream após o recebimento completo da mensagem
            memoryStream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(memoryStream, Encoding.UTF8);
            string response = await reader.ReadToEndAsync();
            return response;
        }


        // Dispose
        public void Dispose()
        {
            _webSocket?.Dispose();
            _cts?.Dispose();
        }
    }
}
