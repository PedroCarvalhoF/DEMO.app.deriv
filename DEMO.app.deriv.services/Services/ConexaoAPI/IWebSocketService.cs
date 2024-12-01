using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public interface IWebSocketService
    {
        Task ConnectAsync();
        bool GetStatusConexao();
        Task SendMessageAsync(object message);
        Task<string> ReceiveMessageAsync();
        Task<string> SendMessageReceiveAsync(object message);
    }
}
