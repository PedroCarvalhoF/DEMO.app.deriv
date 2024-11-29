using DEMO.app.deriv.services.DTOS.Authorize;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Authorize
{
    public interface IAuthorizeServices
    {
        Task<AuthorizeDto> GetAuthorize(string token);
    }
}
