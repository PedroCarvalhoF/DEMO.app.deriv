using System;

namespace DEMO.app.deriv.services.Tools
{
    public static class LogTools
    {
        public static void CwTools(string mensagem)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} - {mensagem}.");
        }
    }
}
