using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.DTOS.ProposalContract;
using DEMO.app.deriv.services.Services.ConexaoAPI;
using System.Text.Json;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.ProposalContract
{
    public class ProposalContractServices : IProposalContractServices
    {
        private readonly WebSocketService _webSocketService;
        public ProposalContractServices(WebSocketService webSocketService)
        {
            _webSocketService = webSocketService;
        }

        public async Task<decimal> GetProposalResponseApenasValorAsync()
        {
            try
            {
                var volatily10 = new
                {
                    proposal = 1,
                    amount = 10,
                    basis = "stake",
                    contract_type = "CALL",
                    currency = "USD",
                    duration = 5,
                    duration_unit = "m",
                    symbol = "R_10"
                };

                var jsonResponse = await _webSocketService.SendAndReceiveMessageAsync(volatily10);

                using (JsonDocument document = JsonDocument.Parse(jsonResponse))
                {
                    JsonElement root = document.RootElement;

                    if (root.TryGetProperty("proposal", out JsonElement authorize))
                    {
                        // Exemplo: Obter o email
                        if (authorize.TryGetProperty("spot", out JsonElement emailElement))
                        {
                             return emailElement.GetDecimal();
                        }
                    }
                }

                return 0;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }

        public async Task<RootObject> GetProposalResponseAsync()
        {
            try
            {
                var volatily10 = new
                {
                    proposal = 1,
                    amount = 10,
                    basis = "stake",
                    contract_type = "CALL",
                    currency = "USD",
                    duration = 5,
                    duration_unit = "m",
                    symbol = "R_10"
                };

                var jsonResponse = await _webSocketService.SendAndReceiveMessageAsync(volatily10);

                var proposalResponse = JsonSerializer.Deserialize<RootObject>(jsonResponse);

                return proposalResponse;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}
