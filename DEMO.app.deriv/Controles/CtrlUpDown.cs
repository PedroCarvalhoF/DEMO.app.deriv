using System.Windows.Forms;

namespace DEMO.app.deriv.Controles
{
    public partial class CtrlUpDown : UserControl
    {
        CtrlUpDown(SetasDirecao direcao)
        {
            InitializeComponent();

            switch (direcao)
            {
                case SetasDirecao.Cima:
                    pctImage.Image = Properties.Resources.seta_cima;
                    break;
                case SetasDirecao.Baixo:
                    pctImage.Image = Properties.Resources.seta_baixo;
                    break;
                case SetasDirecao.DireitaComPonto:
                    pctImage.Image = Properties.Resources.seta_manteve;
                    break;
                default:
                    break;
            }
        }
        public static CtrlUpDown CriarControle(SetasDirecao direcao)
            => new CtrlUpDown(direcao);
    }
    public enum SetasDirecao
    {
        Cima,
        Baixo,
        DireitaComPonto
    }
}
