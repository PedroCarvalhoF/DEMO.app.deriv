using DEMO.app.deriv.services.DTOS.ProposalContract;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.ProposalContract
{
    public interface IProposalContractServices

    {
        Task<RootObject> GetProposalResponseAsync();
    }
}
