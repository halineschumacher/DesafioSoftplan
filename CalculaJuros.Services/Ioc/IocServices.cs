using CalculaJuros.Services.Client;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Services.Ioc
{
    public class IocServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICalculaJurosServices, CalculaJurosServices>();
            services.AddScoped<IRetornaTaxaJurosClient, RetornaTaxaJurosClient>();
        }   
    }
}