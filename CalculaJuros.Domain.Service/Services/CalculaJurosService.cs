using CalculaJuros.Domain.Interfaces;
using CalculaJuros.Domain.Service.Interfaces;
using System;

namespace CalculaJuros.Domain.Service.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly ICalculaJuros _domain;

        public CalculaJurosService(ICalculaJuros domain)
        {
            _domain = domain;
        }

        public decimal Calcula(double valorInicial, int meses)
        {
            throw new NotImplementedException();
        }
    }
}
