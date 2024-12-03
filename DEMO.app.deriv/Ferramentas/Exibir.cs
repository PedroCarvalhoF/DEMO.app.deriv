using System.Drawing;
using System.Windows.Forms;

namespace DEMO.app.deriv.Ferramentas
{
    public class Exibir
    {
        public static DialogResult Modal(Form form)
        {
            Form frm = new Form()
            {
                BackColor = Color.Black,
                Opacity = 0.75,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Maximized
            };

            frm.Show();

            DialogResult result = form.ShowDialog();

            frm.Close();

            return result;
        }     
    }
}
