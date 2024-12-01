using DEMO.app.deriv.services.Services.ConexaoAPI;
using System.IO;
using System.Net.WebSockets;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;

public class WebSocketService : IWebSocketService
{
    private  ClientWebSocket _webSocket;
    private readonly string _uri;
    private readonly CancellationTokenSource _cts;
    private readonly SemaphoreSlim _receiveSemaphore = new SemaphoreSlim(1, 1);
    private int _maxReconnectAttempts = 5; // Número máximo de tentativas de reconexão
    private TimeSpan _reconnectInterval = TimeSpan.FromSeconds(5); // Intervalo entre tentativas de reconexão

    public WebSocketService(string appId)
    {
        _uri = $"wss://ws.derivws.com/websockets/v3?app_id={appId}";
        _webSocket = new ClientWebSocket();
        _cts = new CancellationTokenSource();
    }

    public async Task ConnectAsync()
    {
        int attempt = 0;

        while (attempt < _maxReconnectAttempts)
        {
            try
            {
                if (_webSocket == null || _webSocket.State != WebSocketState.Open)
                {
                    // Certifique-se de liberar a instância anterior antes de criar uma nova
                    _webSocket?.Dispose();
                    _webSocket = new ClientWebSocket();

                    Console.WriteLine("Tentando conectar...");
                    await _webSocket.ConnectAsync(new Uri(_uri), _cts.Token);
                    Console.WriteLine("Conexão estabelecida.");
                    return; // Conexão bem-sucedida, sai do loop
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao tentar conectar: {ex.Message}");
                attempt++;
                if (attempt >= _maxReconnectAttempts)
                {
                    Console.WriteLine("Número máximo de tentativas de reconexão atingido.");
                    throw; // Lança a exceção após atingir o limite de tentativas
                }
                else
                {
                    Console.WriteLine($"Tentando novamente em {_reconnectInterval.TotalSeconds} segundos...");
                    await Task.Delay(_reconnectInterval); // Aguarda antes de tentar novamente
                }
            }
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
            await _receiveSemaphore.WaitAsync();

            if (!GetStatusConexao())
            {
                Console.WriteLine("Conexão está fechada.");
                Console.WriteLine("Reconecatar");
                await ConnectAsync();                
            }

           

            var jsonMessage = JsonSerializer.Serialize(message);

            await _webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(jsonMessage)), WebSocketMessageType.Text, true, CancellationToken.None);
        }
        catch (WebSocketException ex)
        {
            Console.WriteLine($"Erro ao enviar mensagem: {ex.Message}");
            throw new WebSocketException(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
            throw new Exception(ex.Message);
        }
        finally
        {
            _receiveSemaphore.Release(); // Libera o bloqueio após a operação
            
            if (!GetStatusConexao())
            {
                Console.WriteLine("Conexão está fechada.");
                Console.WriteLine("Reconecatar");
                await ConnectAsync();
            }
        }
    }

    public async Task<string> ReceiveMessageAsync()
    {
        await _receiveSemaphore.WaitAsync(); // Adquire o bloqueio antes de começar a operação

        try
        {
            if (!GetStatusConexao())
            {
                Console.WriteLine("Conexão está fechada.");
                Console.WriteLine("Reconecatar");
                await ConnectAsync();
               
            }
            const int bufferSize = 10000; // Tamanho do buffer para leitura
            var buffer = new ArraySegment<byte>(new byte[bufferSize]);

            using (var memoryStream = new MemoryStream())
            {
                WebSocketReceiveResult result;
                do
                {
                    result = await _webSocket.ReceiveAsync(buffer, CancellationToken.None);

                    // Se o servidor enviar um fechamento da conexão
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("A parte remota fechou a conexão.");

                        // Tenta reconectar automaticamente
                        await ReconnectAsync();
                        return string.Empty;
                    }

                    // Escreve os dados recebidos no MemoryStream
                    memoryStream.Write(buffer.Array, buffer.Offset, result.Count);

                } while (!result.EndOfMessage);

                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(memoryStream, Encoding.UTF8))
                {
                    var  to_reader = await reader.ReadToEndAsync();

                    Console.WriteLine($"Mensagem recebida: {to_reader}");

                    return to_reader;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao receber a mensagem: {ex.Message}");
            throw new Exception(ex.Message);
        }
        finally
        {
            _receiveSemaphore.Release(); // Libera o bloqueio após a operação
        }
    }

    public async Task ReconnectAsync()
    {
        // Tentativa de reconectar
        await ConnectAsync();
    }

    public async Task<string> SendMessageReceiveAsync(object message)
    {
        try
        {
            await SendMessageAsync(message);
            return await ReceiveMessageAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao enviar e receber mensagem: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public async Task EscutarContinuamenteAsync()
    {
        try
        {
            // Fica em um loop escutando as mensagens que chegam da API
            while (true)
            {
                string resposta = await ReceiveMessageAsync();

                // Processar a resposta recebida
                Console.WriteLine($"Mensagem recebida: ********** {resposta}");

                // Lógica para processar as mensagens ou até fazer algo com base nas respostas
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro durante a escuta contínua: {ex.Message}");
        }
    }
}
