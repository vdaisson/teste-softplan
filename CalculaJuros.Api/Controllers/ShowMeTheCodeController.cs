using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public string Get()
        {
            return "https://github.com/vdaisson/teste-softplan";
        }
    }
}