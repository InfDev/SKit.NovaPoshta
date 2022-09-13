using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Http;
using SKit.NovaPoshta.Client.Services;

namespace SKit.NovaPoshta.Client.Tests
{
    public class Startup
    {
        
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder
                .ConfigureHostConfiguration(builder => {
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                    builder.AddJsonFile("appsettings.json", optional: false);
                    builder.AddUserSecrets<Startup>();
                })
                .ConfigureAppConfiguration((context, builder) => { 
                });

        public void ConfigureServices(IServiceCollection services, HostBuilderContext context)
        {
            var novaPoshtaGatewayOptions = new NovaPoshtaGatewayOptions();
            context.Configuration.GetSection(NovaPoshtaGatewayOptions.NovaPoshtaGatewaySection).Bind(novaPoshtaGatewayOptions);
            services.AddSingleton<NovaPoshtaGatewayOptions>(novaPoshtaGatewayOptions);

            // Регистрация специализированной фабрики HttpClient для доступа к веб-сервисам 'Нова Пошта'
            services.AddHttpClient<INovaPoshtaGateway, NovaPoshtaGateway>();

            // Регистрация сервисов для работы с методами моделей API 'Нова Пошта'
            services.AddTransient<INpCommonService, NpCommonService>();
            services.AddTransient<INpTrackingDocumentService, NpTrackingDocumentService>();
            services.AddTransient<INpAddressService, NpAddressService>();
        }
    }
}
