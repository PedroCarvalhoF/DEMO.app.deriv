using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.Services;
using System;
using System.Threading.Tasks;

namespace DEMO.app.console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServicosApp.RequisicaoServicos("0000");

            var webSocketService = ServicosApp.WebSocketService;
            await webSocketService.ConnectAsync();

            var authorizeToken = AuthorizeDto.SetToken("meMSIVnpvvReid2");

            var result = await webSocketService.SendAndReceiveMessageAsync(authorizeToken);
           // Console.WriteLine($"Mensagem recebida: {result}");
            Console.ReadLine();
        }
    }
}
