using DEMO.app.deriv.services.DTOS.Contratos;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Contracts
{
    public interface IContractsServices
    {
        Task<Root> GetAllContratosAsyn(string underlying_symbol, string moeda_currency);
    }
}
