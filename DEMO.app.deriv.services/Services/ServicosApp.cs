using DEMO.app.deriv.services.Services.ConexaoAPI;
using DEMO.app.deriv.services.Services.DeriviApi.Authorize;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO.app.deriv.services.Services
{
    public class ServicosApp
    {
        private static ServiceCollection serviceCollection;
        public static IApiService IApiService { get; set; }
        public static WebSocketService WebSocketService { get; private set; }
        public static IAuthorizeServices IAuthorizeServices { get; private set; }
        private static ServiceCollection ColecaoServico(string idApplicationManager)
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<WebSocketService>(provider =>
            {
                string appId = "66069"; // Substitua pelo seu App ID
                return new WebSocketService(appId);
            });
            serviceCollection.AddSingleton<IAuthorizeServices, AuthorizeServices>();

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
            WebSocketService = serviceProvider.GetRequiredService<WebSocketService>();
            IAuthorizeServices = serviceProvider.GetRequiredService<IAuthorizeServices>();
        }
    }
}