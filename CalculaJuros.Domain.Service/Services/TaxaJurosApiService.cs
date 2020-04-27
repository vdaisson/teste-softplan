using CalculaJuros.Domain.Service.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Service.Services
{
    public class TaxaJurosApiService : ITaxaJurosApiService
    {
        private readonly IHttpClientFactory _clientFactory;

        public TaxaJurosApiService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<double> GetTaxaJurosAsync()
        {
            var client = _clientFactory.CreateClient();

            var result = await client.GetAsync("http://taxajuros.api:80/taxajuros");

            if (result.IsSuccessStatusCode)
            {
                return Convert.ToDouble(result.Content.ReadAsStringAsync());
            }

            throw new HttpRequestException(result.StatusCode.ToString());
        }
    }
}
