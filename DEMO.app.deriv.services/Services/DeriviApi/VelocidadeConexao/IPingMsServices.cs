using DEMO.app.deriv.services.DTOS.Ping;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.VelocidadeConexao
{
    public interface IPingMsServices
    {
        Task<PingDto> GetPingMs();
    }
}
