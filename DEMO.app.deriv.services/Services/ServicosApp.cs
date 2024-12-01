using DEMO.app.deriv.services.Services.ConexaoAPI;
using DEMO.app.deriv.services.Services.DeriviApi.Authorize;
using DEMO.app.deriv.services.Services.DeriviApi.Contracts;
using DEMO.app.deriv.services.Services.DeriviApi.ProposalContract;
using DEMO.app.deriv.services.Services.DeriviApi.VelocidadeConexao;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO.app.deriv.services.Services
{
    public class ServicosApp
    {
        private static ServiceCollection serviceCollection;
        public static IApiService IApiService { get; set; }
        public static IWebSocketService IWebSocketService { get; private set; }
        public static IAuthorizeServices IAuthorizeServices { get; private set; }
        public static IPingMsServices IPingMsServices { get; private set; }
        public static IContractsServices IContractsServices { get; private set; }
        public static IProposalContractServices IProposalContractServices { get; private set; } 

        private static ServiceCollection ColecaoServico(string idApplicationManager)
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<IWebSocketService>(provider =>
            {
                string appId = "66069"; // Substitua pelo seu App ID
                return new WebSocketService(appId);
            });
            serviceCollection.AddSingleton<IAuthorizeServices, AuthorizeServices>();
            serviceCollection.AddSingleton<IPingMsServices, PingMsServices>();
            serviceCollection.AddSingleton<IContractsServices, ContractsServices>();
            serviceCollection.AddSingleton<IProposalContractServices, ProposalContractServices>();

            return serviceCollection;
        }
        /// <summary>
        /// informar o id do gerenciador da aplicação
        /// https://api.deriv.com/dashboard/
        /// </summary>
        /// <param name="idApplicationManager"></param>
        /// <returns></returns>
        public static void RequisicaoServicos(string idApplicationManager)
        {
            ServiceProvider serviceProvider = ColecaoServico(idApplicationManager).BuildServiceProvider();
            IApiService = serviceProvider.GetRequiredService<IApiService>();
            IWebSocketService = serviceProvider.GetRequiredService<IWebSocketService>();
            IAuthorizeServices = serviceProvider.GetRequiredService<IAuthorizeServices>();
            IPingMsServices = serviceProvider.GetRequiredService<IPingMsServices>();
            IContractsServices = serviceProvider.GetRequiredService<IContractsServices>();
            IProposalContractServices = serviceProvider.GetRequiredService<IProposalContractServices>();
        }
    }
}