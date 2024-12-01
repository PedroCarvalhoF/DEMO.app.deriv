using DEMO.app.deriv.services.DTOS.Authorize;
using DEMO.app.deriv.services.Services.ConexaoAPI;
using System.Text.Json;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Authorize
{
    public class AuthorizeServices : IAuthorizeServices
    {
        private readonly IWebSocketService _webSocketService;

        public AuthorizeServices(IWebSocketService webSocketService)
        {
            _webSocketService = webSocketService;
        }

        public async Task<AuthorizeDto> GetAuthorize(string token)
        {
            try
            {
                var tokenAuthorize = new
                {
                    authorize = token
                };

                var response = await _webSocketService.SendMessageReceiveAsync(tokenAuthorize);

                var authorizeDto = new AuthorizeDto();

                using (JsonDocument document = JsonDocument.Parse(response))
                {

                    JsonElement root = document.RootElement;
                    if (root.TryGetProperty("authorize", out JsonElement authorize))
                    {
                        // Exemplo: Obter o email
                        if (authorize.TryGetProperty("email", out JsonElement emailElement))
                        {
                            authorizeDto.email = emailElement.GetString();                            
                        }
                        if (authorize.TryGetProperty("fullname", out JsonElement fullnameElement))
                        {
                            authorizeDto.fullname = fullnameElement.GetString();
                        }

                        // Exemplo: Obter o balance
                        if (authorize.TryGetProperty("balance", out JsonElement balanceElement))
                        {
                            authorizeDto.balance = balanceElement.GetDecimal();                           
                        }

                        // Iterar na lista de contas
                        if (authorize.TryGetProperty("account_list", out JsonElement accountList))
                        {
                            foreach (JsonElement account in accountList.EnumerateArray())
                            {
                                authorizeDto.loginid = account.GetProperty("loginid").GetString();                             
                            }
                        }
                    }
                }

                return authorizeDto;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}
