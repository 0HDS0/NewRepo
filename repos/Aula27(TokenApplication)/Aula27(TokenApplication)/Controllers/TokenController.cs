using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula27_TokenApplication_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        [Route("Teste")]
        public async Task<IActionResult> TesteToken()
        {
            return Ok("O token funciona!");
        }
    }
}
