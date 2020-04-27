using Microsoft.Extensions.DependencyInjection;
using CalculaJuros.Domain.Interfaces;
using CalculaJuros.Domain.Service.Interfaces;
using CalculaJuros.Domain.Service.Services;

namespace CalculaJuros.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddCalculaJurosServices(this IServiceCollection services)
        {
            services.AddTransient<ICalculaJuros, Domain.CalculaJuros>();
            services.AddTransient<ICalculaJurosService, CalculaJurosService>();
        }
    }
}
