using DEMO.app.deriv.services.Services.ConexaoAPI;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO.app.deriv.services.Services
{
    public class ServicosApp
    {
        private static ServiceCollection serviceCollection;
        public static IApiService IApiService { get; set; }
        public static WebSocketService WebSocketService { get; private set; }
        private static ServiceCollection ColecaoServico()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<WebSocketService>(provider =>
            {
                string appId = "66069"; // Substitua pelo seu App ID
                return new WebSocketService(appId);
            });

            return serviceCollection;
        }
        public static void RequisicaoServicos()
        {
            ServiceProvider serviceProvider = ColecaoServico().BuildServiceProvider();
            IApiService = serviceProvider.GetRequiredService<IApiService>();
            WebSocketService = serviceProvider.GetRequiredService<WebSocketService>();
        }
    }
}