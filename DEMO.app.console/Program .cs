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
            ServicosApp.RequisicaoServicos();

            var webSocketService = ServicosApp.WebSocketService;
            await webSocketService.ConnectAsync();

            var authorizeToken = AuthorizeDto.SetToken("H5ZyfaEiAWBB5C7");

            var result = await webSocketService.SendAndReceiveMessageAsync(authorizeToken);
           // Console.WriteLine($"Mensagem recebida: {result}");
            Console.ReadLine();
        }
    }
}
