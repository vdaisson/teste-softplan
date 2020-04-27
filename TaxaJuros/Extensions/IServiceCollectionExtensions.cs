using Microsoft.Extensions.DependencyInjection;
using TaxaJuros.Domain.Interfaces.Repositories;
using TaxaJuros.Domain.Service.Interfaces;
using TaxaJuros.Domain.Service.Services;
using TaxaJuros.Infrastructure.Data.Repositories.TaxaJuros;

namespace TaxaJuros.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddTaxaJurosServices(this IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosRepository, TaxaJurosRepository>();
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();
        }
    }
}
