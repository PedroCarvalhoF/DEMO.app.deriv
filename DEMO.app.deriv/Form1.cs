using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.DTOS.Ping;
using DEMO.app.deriv.services.DTOS.Ticks;
using DEMO.app.deriv.services.Services;
using DEMO.app.deriv.services.Services.ConexaoAPI;
using DEMO.app.deriv.services.Services.DeriviApi.Authorize;
using DEMO.app.deriv.services.Services.DeriviApi.Contracts;
using DEMO.app.deriv.services.Services.DeriviApi.Ticks;
using DEMO.app.deriv.services.Services.DeriviApi.VelocidadeConexao;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class Form1 : Form
    {
        private IAuthorizeServices _authorizerServices;
        private IPingMsServices _pingMsServices;
        private IWebSocketService _webSocketServices;
        private IContractsServices _contratosServices;
        private ITickServices _tickServices;
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos

        private void AtualizarCamposAuthorizeDto(AuthorizeDto dto, PingDto pingMs)
        {
            if (dto == null) return;
            txtEmail.Text = dto.email;
            txtFullName.Text = dto.fullname;

            txtConta.Text = dto.loginid;
            txtSaldoInicial.Text = dto.balance.ToString();

            txtPingMs.Text = pingMs.ping.ToString();

            txtConta.TextBoxPasswordChar();
            txtEmail.TextBoxPasswordChar();
            txtFullName.TextBoxPasswordChar();
            txtToken.TextBoxPasswordChar();


        }

        #endregion
        #region Eventos


        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtToken.Text))
                {
                    MessageBox.Show("Informe o TOKEN.");
                    return;
                }

                var token_text = txtToken.Text;

                //passa o token para serviços 
                //inicializa as injeções 
                ServicosApp.RequisicaoServicos(token_text);

                //realizar conexao


                await ServicosApp.IWebSocketService.ConnectAsync();

                _webSocketServices = ServicosApp.IWebSocketService;
                _pingMsServices = ServicosApp.IPingMsServices;
                _authorizerServices = ServicosApp.IAuthorizeServices;
                _contratosServices = ServicosApp.IContractsServices;
                _tickServices = ServicosApp.ITickServices;


                var result = await _authorizerServices.GetAuthorize(txtToken.Text);

                var resultPingMs = await _pingMsServices.GetPingMs();

                AtualizarCamposAuthorizeDto(result, resultPingMs);


            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnExibirOcultarToken_Click(object sender, System.EventArgs e)
        {
            txtConta.TextBoxPasswordChar();
            txtEmail.TextBoxPasswordChar();
            txtFullName.TextBoxPasswordChar();
            txtToken.TextBoxPasswordChar();
        }
        #endregion

        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private async void btnFiltrarContratoIndiceVolatividade_Click(object sender, System.EventArgs e)
        {
            try
            {
                lblTickValue.Text = "Conectando...";
                _cancellationTokenSource = new CancellationTokenSource();
                try
                {
                    // Inicia a observação de ticks
                    await _tickServices.ObserveTicksAsync(cmbxUnderlying_symbol.Text, _cancellationTokenSource.Token, UpdateTickValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateTickValue(double tickValue)
        {
            // Atualiza a Label na thread da interface gráfica
            if (lblTickValue.InvokeRequired)
            {
                lblTickValue.Invoke(new Action(() => lblTickValue.Text = $"Tick: {tickValue}"));
            }
            else
            {
                lblTickValue.Text = $"Tick: {tickValue}";
            }
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            var contratoResult = await _contratosServices.GetAllContratosAsyn(cmbxUnderlying_symbol.Text, cmbxMoeda.Text);

            var contratos_filtrados = contratoResult.contracts_for.available.Where(ctr => ctr.contract_category_display == "Rise/Fall Equal" && ctr.expiry_type == "tick");

            dtContratos.DataSource = contratos_filtrados.ToList();
        }

        private void cmbxMoeda_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                switch (cmbxMoeda.Text)
                {
                    case "USD":
                        lblMoedaSelecionada.Text = "Dólar Americano";
                        break;
                    case "EUR":
                        lblMoedaSelecionada.Text = "Euro";
                        break;
                    case "GBP":
                        lblMoedaSelecionada.Text = "Libra Esterlina";
                        break;
                    case "AUD":
                        lblMoedaSelecionada.Text = "Dólar Australiano";
                        break;
                    case "JPY":
                        lblMoedaSelecionada.Text = "Iene Japonês";
                        break;
                    case "CHF":
                        lblMoedaSelecionada.Text = "Franco Suíço";
                        break;
                    case "NZD":
                        lblMoedaSelecionada.Text = "Dólar Neozelandês";
                        break;

                    case "CAD":
                        lblMoedaSelecionada.Text = "Dólar Canadense";
                        break;


                    default:
                        lblMoedaSelecionada.Text = "Selecione uma moeda";
                        break;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            cmbxMoeda.SelectedText = "USD";
        }

        private void btnFiltrar_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRaiseFail_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (FrmRiseFail frm = new FrmRiseFail())
                {
                    frm.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            lblTickValue.Text = "Observação parada.";
        }
    }
}
