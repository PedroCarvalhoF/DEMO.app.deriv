using DEMO.app.deriv.services.DTOS.Ping;
using DEMO.app.deriv.services.Services.ConexaoAPI;
using System.Text.Json;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.VelocidadeConexao
{
    public class PingMsServices : IPingMsServices
    {
        private readonly WebSocketService _webSocketService;

        public PingMsServices(WebSocketService webSocketService)
        {
            _webSocketService = webSocketService;
        }

        public async Task<PingDto> GetPingMs()
        {
            try
            {
                var pingMs = new
                {
                    ping = 1
                };

                var response = await _webSocketService.SendAndReceiveMessageAsync(pingMs);

                var dtoPing = new PingDto();

                using (JsonDocument document = JsonDocument.Parse(response))
                {

                    JsonElement root = document.RootElement;
                    if (root.TryGetProperty("echo_req", out JsonElement authorize))
                    {
                        // Exemplo: Obter o email
                        if (authorize.TryGetProperty("ping", out JsonElement ping))
                        {
                            dtoPing.ping = ping.GetInt32();
                        }
                    }
                }

                return dtoPing;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}
