using Microsoft.Extensions.DependencyInjection;
using TaxaDeJuros.Repository;

namespace TaxaDeJuros.Services.IoC
{
    public class IocServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosServices, TaxaDeJurosServices>();
            services.AddScoped<ITaxaDeJurosRepository, TaxaDeJurosRepository>();
        }   
    }
}