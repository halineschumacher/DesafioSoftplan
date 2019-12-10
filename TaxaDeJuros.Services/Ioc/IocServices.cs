using Microsoft.Extensions.DependencyInjection;

namespace TaxaDeJuros.Services.IoC
{
    public class IocServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosServices, TaxaDeJurosServices>();
        }   
    }
}