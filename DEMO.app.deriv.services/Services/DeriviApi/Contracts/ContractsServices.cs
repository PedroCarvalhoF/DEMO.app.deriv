using DEMO.app.deriv.services.DTOS.Contratos;
using DEMO.app.deriv.services.Services.ConexaoAPI;
using System.Text.Json;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Contracts
{
    public class ContractsServices : IContractsServices
    {
        private readonly WebSocketService _webSocketService;

        public ContractsServices(WebSocketService webSocketService)
        {
            _webSocketService = webSocketService;
        }

        public async Task<Root> GetAllContratosAsyn(string underlying_symbol, string moeda_currency)
        {
            try
            {
                var contratos = new
                {
                    contracts_for = underlying_symbol,
                    currency = moeda_currency,
                    landing_company = "svg",
                    product_type = "basic"
                };

                var json = await _webSocketService.SendAndReceiveMessageAsync(contratos);

                var responseDto = JsonSerializer.Deserialize<Root>(json);

                return responseDto;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }

       
    }
}
