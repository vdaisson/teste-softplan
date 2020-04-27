using CalculaJuros.Domain.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _service;

        public CalculaJurosController(ICalculaJurosService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public decimal Get(double valorInicial, int meses)
        {
            return _service.Calcula(valorInicial, meses);
        }
    }
}
