using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Domain.Service.Interfaces;

namespace TaxaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _service;

        public TaxaJurosController(ITaxaJurosService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public double Get()
        {
            return _service.Get();
        }
    }
}
