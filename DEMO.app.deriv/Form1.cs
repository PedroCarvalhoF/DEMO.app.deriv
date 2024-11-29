using DEMO.app.deriv.Ferramentas;
using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.Services;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos

        private void AtualizarCamposAuthorizeDto(AuthorizeDto dto)
        {
            if (dto == null) return;
            txtEmail.Text = dto.email;
            txtFullName.Text = dto.fullname;

            txtConta.Text = dto.loginid;
            txtSaldoInicial.Text = dto.balance.ToString();
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
                await ServicosApp.WebSocketService.ConnectAsync();

                //verifica conexão
                if (ServicosApp.WebSocketService.GetStatusConexaoWebSockets())
                    MessageBox.Show("Conexão estabelicida.");
                else
                    MessageBox.Show("Sem coneção.");


                var result = await ServicosApp.IAuthorizeServices.GetAuthorize(txtToken.Text);

                AtualizarCamposAuthorizeDto(result);
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnExibirOcultarToken_Click(object sender, System.EventArgs e)
        {
            txtToken.PasswordChar = txtToken.PasswordChar == '*' ? '\0' : '*';
        }
        #endregion
    }
}
