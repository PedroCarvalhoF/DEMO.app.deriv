using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public interface IApiService
    {
        Task<string> ConectWebSockets();
    }
}
