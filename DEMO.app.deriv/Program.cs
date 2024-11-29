using DEMO.app.deriv.services.Services;
using System;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServicosApp.RequisicaoServicos();
            Application.Run(new Form1());
        }
    }
}
