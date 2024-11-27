using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public interface IApiService
    {
        Task<string> Get(string token, string url, object objGet = null);
        Task<string> Post(string token, string url, object objCreate = null);
        Task<string> Put(string token, string url, object objUpdate = null);       
        Task<string> Delete(string token, string url, object objDelete = null);
    }
}
