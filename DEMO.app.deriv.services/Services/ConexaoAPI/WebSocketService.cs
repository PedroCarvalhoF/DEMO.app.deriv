using DEMO.app.deriv.services.Services.ConexaoAPI;
using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

public class WebSocketService : IWebSocketService
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

    public async Task ConnectAsync()
    {
        try
        {
            if (_webSocket.State != WebSocketState.Open)
                await _webSocket.ConnectAsync(new Uri(_uri), _cts.Token);
        }
        catch (WebSocketException ex)
        {
            throw new WebSocketException(ex.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public async Task<ClientWebSocket> GetClientWebSocketOpen()
    {
        await ConnectAsync();

        return _webSocket;
    }
    public bool GetStatusConexao() => _webSocket.State == WebSocketState.Open;
    public async Task SendMessageAsync(object message)
    {
        try
        {
            if (!GetStatusConexao())
            {
                throw new ArgumentException("Conexão está fechada");
            }

            var jsonMessage = JsonSerializer.Serialize(message);

            await _webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(jsonMessage)), WebSocketMessageType.Text, true, CancellationToken.None);
        }
        catch (WebSocketException ex)
        {
            throw new WebSocketException(ex.Message);
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
    public async Task<string> ReceiveMessageAsync()
    {
        try
        {
            const int bufferSize = 4096; // Tamanho do buffer para leitura
            var buffer = new ArraySegment<byte>(new byte[bufferSize]);

            // Substituindo o uso do 'using' por uma declaração tradicional
            using (var memoryStream = new MemoryStream())
            {
                WebSocketReceiveResult result;
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

                // Faz a leitura do MemoryStream após o recebimento completo da mensagem
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(memoryStream, Encoding.UTF8))
                {
                    string response = await reader.ReadToEndAsync();
                    return response;
                }
            }
        }
        catch (WebSocketException ex)
        {
            throw new WebSocketException(ex.Message);
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public async Task<string> SendMessageReceiveAsync(object message)
    {
        try
        {
            await SendMessageAsync(message);
            return await ReceiveMessageAsync();
        }
        catch (WebSocketException ex)
        {
            throw new WebSocketException(ex.Message);
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
}
