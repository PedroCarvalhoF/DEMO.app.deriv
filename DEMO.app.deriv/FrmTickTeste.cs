using System;
using System.Net.WebSockets;
using System.Text.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class FrmTickTeste : Form
    {
        private static readonly Uri uri = new Uri("wss://ws.derivws.com/websockets/v3?app_id=66069"); // Replace with your app_id if needed
        public FrmTickTeste()
        {
            InitializeComponent();
        }

        bool commandEnviado = false;
        ClientWebSocket webSocket = new ClientWebSocket();

        private async void FrmTickTeste_Load(object sender, EventArgs e)
        {
            while (true) // Loop infinito, para tentar reconectar ou reiniciar o processo após uma falha
            {
                try
                {
                    if (webSocket.State != WebSocketState.Open)
                    {
                        Console.WriteLine("Attempting to connect to WebSocket...");
                        webSocket = null;
                        webSocket = new ClientWebSocket();
                        await webSocket.ConnectAsync(uri, CancellationToken.None);
                        Console.WriteLine("[status] WebSocket connection established.");
                    }

                    if (!commandEnviado)
                    {
                        // Envia o comando de assinatura se ainda não foi enviado
                        var subscriptionRequest = new { ticks = "R_100", subscribe = 1 };
                        string requestMessage = JsonSerializer.Serialize(subscriptionRequest);
                        var requestBytes = Encoding.UTF8.GetBytes(requestMessage);
                        var requestSegment = new ArraySegment<byte>(requestBytes);

                        await webSocket.SendAsync(requestSegment, WebSocketMessageType.Text, true, CancellationToken.None);
                        commandEnviado = true;
                    }

                    var buffer = new byte[8192];

                    // Recebe mensagens do WebSocket
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

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
                            lblTickValue.Text = quote.ToString();
                        }
                    }
                }
                catch (WebSocketException ex)
                {
                    commandEnviado = false;
                    Console.WriteLine($"Erro WebSocket: {ex.Message}. Tentando reconectar...");
                    //await Task.Delay(1000); // Atraso antes de tentar reconectar
                }
                catch (Exception ex)
                {
                    commandEnviado = false;
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                    //await Task.Delay(1000); // Atraso antes de tentar reconectar
                }
            }
        }
    }
}
