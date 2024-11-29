using DEMO.app.deriv.services.Services.ConexaoAPI;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO.app.deriv.services.Services
{
    public class ServicosApp
    {
        private static ServiceCollection serviceCollection;
        public static IApiService IApiService { get; set; }
        private static ServiceCollection ColecaoServico()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();

            return serviceCollection;
        }
        public static void RequisicaoServicos()
        {
            ServiceProvider serviceProvider = ColecaoServico().BuildServiceProvider();
            IApiService = serviceProvider.GetRequiredService<IApiService>();
        }
}