using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.DTOS.Ping;
using DEMO.app.deriv.services.Services.DeriviApi.Authorize;
using DEMO.app.deriv.services.Services.DeriviApi.Ticks;
using DEMO.app.deriv.services.Services.DeriviApi.VelocidadeConexao;
using DEMO.app.deriv.services.Tools;
using LiveCharts;
using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class FrmRiseFail : Form
    {
        private ITickServices _tickServices;
        private IAuthorizeServices _authorizeServices;
        private IPingMsServices _pingMsServices;
        private ChartValues<double> _values;
        private int contador_tick_compra = 1;

        #region Metodos teste antes de criar o servico
        public async Task ExecuteRiseFallTrade(string token, string symbol_contract, double stake, int duration_tick_time, string durationUnit, string contractType)
        {
            var stop_wathc = Stopwatch.StartNew();

            using (var webSocket = new ClientWebSocket())
            {
                LogTools.CwTools("Realizando conexão com WebSockt Deriv");
                await webSocket.ConnectAsync(new Uri(ApiUrl), CancellationToken.None);

                // Autenticar
                var authMessage = new { authorize = token };
                LogTools.CwTools("Autenticando usuário com token");
                await SendMessage(webSocket, authMessage);
                LogTools.CwTools("Recebendo reposta do token");
                var response = await ReceiveMessage(webSocket);
                LogTools.CwTools($"Reposta: {response}");

                LogTools.CwTools("Configurando prospota de compra");
                // Mensagem de compra
                var buyMessage = new
                {
                    proposal = 1,
                    amount = stake,
                    basis = "stake",
                    contract_type = contractType,
                    currency = "USD", // padrao no momento 
                    duration = duration_tick_time,
                    duration_unit = "t",
                    symbol = symbol_contract
                };

                LogTools.CwTools("Enviando proposta de compra");
                //enviando solicitacao de proposta
                await SendMessage(webSocket, buyMessage);

                string id_proposal = string.Empty;


                LogTools.CwTools("Recebendo resposta do contrato");
                var buffer = new byte[8192];
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                string message = Encoding.UTF8.GetString(buffer, 0, result.Count);


                LogTools.CwTools($"Proposta recebida: {message}");
                using (JsonDocument document = JsonDocument.Parse(message))
                {
                    JsonElement root = document.RootElement;
                    if (root.TryGetProperty("proposal", out JsonElement proposal))
                    {

                        if (proposal.TryGetProperty("id", out JsonElement idElemente))
                        {

                            id_proposal = idElemente.GetString();
                        }
                    }
                }

                //recebendo retorno da proposta

                //stop_wathc.Stop();
                LogTools.CwTools($"ID da proposta recebido em : {stop_wathc.ElapsedMilliseconds} ms");

                var buyProposal = new
                {
                    buy = id_proposal,
                    price = stake
                };

                await SendMessage(webSocket, buyProposal);

                LogTools.CwTools("Compra finalizada.");
                var bufferbuyProposal = new byte[1024 * 4];
                var resultbuyProposal = await webSocket.ReceiveAsync(new ArraySegment<byte>(bufferbuyProposal), CancellationToken.None);

                string messagebuyProposal = Encoding.UTF8.GetString(bufferbuyProposal, 0, resultbuyProposal.Count);
                LogTools.CwTools($"Resulta operacao de compra: {messagebuyProposal}");

                stop_wathc.Stop();
                LogTools.CwTools($"Operação finalizada em : {stop_wathc.ElapsedMilliseconds} ms");
            }
        }



        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        public async Task ExecuteRiseFallTradeWebSocketOpem(ClientWebSocket clientWebSocket_sempre_opem, string token, string symbol_contract, double stake, int duration_tick_time, string durationUnit, string contractType)
        {
            await _semaphore.WaitAsync();

            LogTools.CwTools("##################    INCIANDO OPERACÃO   ##############");
            LogTools.CwTools("");
            LogTools.CwTools("");
            LogTools.CwTools("");
            var stop_wathc = Stopwatch.StartNew();

            if (clientWebSocket_sempre_opem.State != WebSocketState.Open)
            {
                LogTools.CwTools(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> WebSockt não é mais o mesmo. Realizando reconexão.");
                clientWebSocket_sempre_opem = new ClientWebSocket();
                await clientWebSocket_sempre_opem.ConnectAsync(new Uri(ApiUrl), CancellationToken.None);
            }




            // Autenticar
            var authMessage = new { authorize = token };
            LogTools.CwTools("Autenticando usuário com token");
            await SendMessage(clientWebSocket_sempre_opem, authMessage);
            LogTools.CwTools("Recebendo reposta do token");
            var response = await ReceiveMessage(clientWebSocket_sempre_opem);
            LogTools.CwTools($"Reposta: {response}");

            LogTools.CwTools("Configurando prospota de compra");
            // Mensagem de compra
            var buyMessage = new
            {
                proposal = 1,
                amount = stake,
                basis = "stake",
                contract_type = contractType,
                currency = "USD", // padrao no momento 
                duration = duration_tick_time,
                duration_unit = "t",
                symbol = symbol_contract
            };

            LogTools.CwTools("Enviando proposta de compra");
            //enviando solicitacao de proposta
            await SendMessage(clientWebSocket_sempre_opem, buyMessage);

            string id_proposal = string.Empty;


            LogTools.CwTools("Recebendo resposta do contrato");
            var buffer = new byte[8192];
            var result = await clientWebSocket_sempre_opem.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            string message = Encoding.UTF8.GetString(buffer, 0, result.Count);


            LogTools.CwTools($"Proposta recebida: {message}");
            using (JsonDocument document = JsonDocument.Parse(message))
            {
                JsonElement root = document.RootElement;
                if (root.TryGetProperty("proposal", out JsonElement proposal))
                {

                    if (proposal.TryGetProperty("id", out JsonElement idElemente))
                    {

                        id_proposal = idElemente.GetString();
                    }
                }
            }

            //recebendo retorno da proposta

            //stop_wathc.Stop();
            LogTools.CwTools($"ID da proposta recebido em : {stop_wathc.ElapsedMilliseconds} ms");

            var buyProposal = new
            {
                buy = id_proposal,
                price = stake
            };

            await SendMessage(clientWebSocket_sempre_opem, buyProposal);

            LogTools.CwTools("Compra finalizada.");
            var bufferbuyProposal = new byte[1024 * 4];
            var resultbuyProposal = await clientWebSocket_sempre_opem.ReceiveAsync(new ArraySegment<byte>(bufferbuyProposal), CancellationToken.None);

            string messagebuyProposal = Encoding.UTF8.GetString(bufferbuyProposal, 0, resultbuyProposal.Count);
            LogTools.CwTools($"Resulta operacao de compra: {messagebuyProposal}");

            stop_wathc.Stop();
            LogTools.CwTools($"Operação finalizada em : {stop_wathc.ElapsedMilliseconds} ms");

            LogTools.CwTools("");
            LogTools.CwTools("");
            LogTools.CwTools("");
            LogTools.CwTools("##################    FIM OPERACÃO   ##############");


            _semaphore.Release();
        }

        private async Task SendMessage(ClientWebSocket webSocket, object message)
        {
            string jsonMessage = JsonSerializer.Serialize(message);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonMessage);
            await webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        private async Task<string> ReceiveMessage(ClientWebSocket webSocket)
        {
            var buffer = new byte[8192];
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            return Encoding.UTF8.GetString(buffer, 0, result.Count);
        }
        #endregion

        //TESTE

        private const string ApiUrl = "wss://ws.derivws.com/websockets/v3?app_id=66069";
        private static readonly Uri uriWebSempreOpem = new Uri(ApiUrl);

        #region Testando WebSocktPermanente OPEM

        private ClientWebSocket _webSocketSemAberto;

        #endregion
        public FrmRiseFail(ITickServices _tickServices, IAuthorizeServices authorize, IPingMsServices _pingMsServices, string token, decimal valor_saldo_incial)
        {
            this._tickServices = _tickServices;
            this._authorizeServices = authorize;
            this._pingMsServices = _pingMsServices;
            this.valor_saldo_incial = valor_saldo_incial;
            _values = new ChartValues<double>();

            InitializeComponent();

            txtToken.Text = token;




        }



        private async void FrmRiseFail_Load(object sender, System.EventArgs e)
        {
            var result = await _authorizeServices.GetAuthorize(txtToken.Text);

            var resultPingMs = await _pingMsServices.GetPingMs();

            AtualizarCamposAuthorizeDto(result, resultPingMs);
            cmbxUnderlying_symbol.SelectedIndex = 0;

            _webSocketSemAberto = new ClientWebSocket();
            await _webSocketSemAberto.ConnectAsync(uriWebSempreOpem, CancellationToken.None);


        }

        decimal valor_saldo_incial = 0;
        decimal valor_saldo_final = 0;
        decimal valor_saldo_atual = 0;
        private void AtualizarCamposAuthorizeDto(AuthorizeDto dto, PingDto pingMs)
        {
            if (dto == null) return;

            txtSaldoInicial.Text = dto.balance.ToString();
            txtPingMs.Text = pingMs.ping.ToString();

            valor_saldo_atual = dto.balance;
            valor_saldo_final = valor_saldo_atual - valor_saldo_incial;

            txtSaldoFinal.Text = valor_saldo_incial.ToString();
        }

        private void btnAddTick_Click(object sender, System.EventArgs e)
        {
            QtdTickAdicionarRemover(1);
        }

        private void btnRemoveTick_Click(object sender, System.EventArgs e)
        {
            QtdTickAdicionarRemover(-1);
        }

        private void QtdTickAdicionarRemover(int addContador)
        {
            contador_tick_compra += addContador;
            if (contador_tick_compra < 1)
                contador_tick_compra = 1;

            if (contador_tick_compra > 10)
                contador_tick_compra = 10;

            lblQtdTick.Text = $"{contador_tick_compra} Ticks";
        }
        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private async void btnFiltrarContratoIndiceVolatividade_Click(object sender, EventArgs e)
        {

            try
            {
                lblTickValue.Text = "Conectando...";
                btnStop.Enabled = true;

                btnFiltrarContratoIndiceVolatividade.Enabled = false;
                cmbxUnderlying_symbol.Enabled = false;

                // Captura o texto do ComboBox no thread principal
                string indice = cmbxUnderlying_symbol.Text;

                if (string.IsNullOrWhiteSpace(indice))
                {
                    MessageBox.Show("Por favor, selecione um índice válido.");
                    return;
                }

                // Cancela qualquer execução anterior
                _cancellationTokenSource?.Cancel();

                // Cria uma nova fonte de token
                _cancellationTokenSource = new CancellationTokenSource();

                // Observa os ticks de forma assíncrona sem bloquear a thread principal
                await _tickServices.ObserveTicksAsync(
                    indice,
                    _cancellationTokenSource.Token,
                    UpdateTickValue
                );



            }
            catch (OperationCanceledException)
            {
                lblTickValue.Text = "Observação cancelada.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void UpdateTickValue(double tickValue)
        {
            if (lblTickValue.InvokeRequired)
            {
                lblTickValue.Invoke(new Action<double>((value) =>
                {
                    lblTickValue.Text = value.ToString();
                    _values.Add(tickValue);
                    ManipularTick(tickValue);
                }), tickValue);
            }
            else
            {
                lblTickValue.Text = tickValue.ToString();
                _values.Add(tickValue);
                ManipularTick(tickValue);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            btnStop.Enabled = false;
            btnFiltrarContratoIndiceVolatividade.Enabled = true;
            cmbxUnderlying_symbol.Enabled = true;

            _values.Clear();
        }


        private void ManipularTick(double tickValue)
        {

        }

        private async void btnRise_Click(object sender, EventArgs e)
        {
            try
            {
                lblRiseTickCompra.Text = lblTickValue.Text;
                //manual duracao
                //await ExecuteRiseFallTrade(
                //txtToken.Text,   // Token de autenticação
                //cmbxUnderlying_symbol.Text,             // Índice
                //Convert.ToDouble(txtValorEntrada.Text),                 // Stake (valor da aposta)
                //contador_tick_compra,                  // Duração
                //"t",                // Unidade de duração (ticks)
                //"CALL"              // Tipo de contrato: "CALL" (Rise) ou "PUT" (Fall)
                //);

                //passando web socket aberto
                await ExecuteRiseFallTradeWebSocketOpem(_webSocketSemAberto,
               txtToken.Text,   // Token de autenticação
               cmbxUnderlying_symbol.Text,             // Índice
               Convert.ToDouble(txtValorEntrada.Text),                 // Stake (valor da aposta)
               contador_tick_compra,                  // Duração
               "t",                // Unidade de duração (ticks)
               "CALL"              // Tipo de contrato: "CALL" (Rise) ou "PUT" (Fall)
               );


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void btnFall_Click(object sender, EventArgs e)
        {
            try
            {
                lblRiseTickCompra.Text = lblTickValue.Text;
                //manual duracao
                await ExecuteRiseFallTrade(
                txtToken.Text,   // Token de autenticação
                cmbxUnderlying_symbol.Text,             // Índice
                Convert.ToDouble(txtValorEntrada.Text),                 // Stake (valor da aposta)
                contador_tick_compra,                  // Duração
                "t",                // Unidade de duração (ticks)
                "PUT"              // Tipo de contrato: "CALL" (Rise) ou "PUT" (Fall)
                );

                //manual duracao
                await ExecuteRiseFallTradeWebSocketOpem(_webSocketSemAberto,
                txtToken.Text,   // Token de autenticação
                cmbxUnderlying_symbol.Text,             // Índice
                Convert.ToDouble(txtValorEntrada.Text),                 // Stake (valor da aposta)
                contador_tick_compra,                  // Duração
                "t",                // Unidade de duração (ticks)
                "PUT"              // Tipo de contrato: "CALL" (Rise) ou "PUT" (Fall)
                );


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                await ExecuteRiseFallTradeWebSocketOpem(_webSocketSemAberto,
               txtToken.Text,   // Token de autenticação
               cmbxUnderlying_symbol.Text,             // Índice
               Convert.ToDouble(txtValorEntrada.Text),                 // Stake (valor da aposta)
               contador_tick_compra,                  // Duração
               "t",                // Unidade de duração (ticks)
               "CALL"              // Tipo de contrato: "CALL" (Rise) ou "PUT" (Fall)
               );
            }
        }
    }
}
