using Aula14.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        [HttpPost]
        [Route("novo")]
        public async Task<IActionResult> Post([FromBody] Servico servico)
        {
            return Ok(servico);
        }
    }
}
