using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula26_CORS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            return Ok("Está funcionando!");
        }

    }
}
