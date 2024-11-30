using DEMO.app.deriv.services.Services;
using DEMO.app.deriv.services.Services.DeriviApi.ProposalContract;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class FrmRiseFail : Form
    {
        private readonly IProposalContractServices _proposalContractServices;
        public FrmRiseFail()
        {
            InitializeComponent();

            _proposalContractServices = ServicosApp.IProposalContractServices;
        }

        private void FrmRiseFail_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private async void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                var resultContract = await _proposalContractServices.GetProposalResponseAsync();
                txtPrecoContrato.Text = resultContract.proposal.spot.ToString();

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }
    }
}
