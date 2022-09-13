//using System.Net.Http;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Http;
//using SKit.NovaPoshta.Client;
//using SKit.NovaPoshta.Client.Services;

using SKit.NovaPoshta.Client;
using SKit.NovaPoshta.Client.Services;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        //        public static IServiceCollection AddNovaPoshtaClient(this IServiceCollection services, IConfiguration configuration)
        //        {
        //            var novaPoshtaGatewayOptions = new NovaPoshtaGatewayOptions();
        //            configuration.GetSection(NovaPoshtaGatewayOptions.NovaPoshtaGatewaySection).Bind(novaPoshtaGatewayOptions);
        //            services.AddSingleton<NovaPoshtaGatewayOptions>(novaPoshtaGatewayOptions);

        //            // Регистрация специализированной фабрики HttpClient для доступа к веб-сервисам 'Нова Пошта'
        //            services.AddHttpClient<INovaPoshtaGateway, NovaPoshtaGateway>();

        //            // Регистрация сервисов для работы с методами моделей API 'Нова Пошта'
        //            services.AddTransient<INpCommonService, NpCommonService>();
        //            services.AddTransient<INpTrackingDocumentService, NpTrackingDocumentService>();
        //            services.AddTransient<INpAddressService, NpAddressService>();

        //            return services;
        //        }

        public static async Task WithoutDependencyInjectionSample()
        {
            var npGatewayOptions = new NovaPoshtaGatewayOptions(apiKey: "******");
            var httpClient = new HttpClient();
            INovaPoshtaGateway npGateway = new NovaPoshtaGateway(httpClient, npGatewayOptions);

            INpCommonService npCommonService = new NpCommonService(npGateway);
            // ...
            INpTrackingDocumentService npTrackingDocumentService = new NpTrackingDocumentService(npGateway);
            // ...
            INpAddressService npAddressService = new NpAddressService(npGateway);
            var response = await npAddressService.SearchSettlementsAsync("Київ");
            var dataList = response?.Data;
            var itemCount = dataList?.Count ?? 0;
            // ...
        }
    }
}
