using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula26_CORS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {

        //Cors-1
        //É o padrão da nossa aplicação
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            return Ok("Está funcionando!");
        }

        //A principio fica no cors-1
        [HttpGet]
        [Route("cors2")]
        //Ativa o acesso ao Cors-2
        [EnableCors("Cors-2")]
        public async Task<IActionResult> GetCors2()
        {
            return Ok("Está funcionando o CORS 2!");
        }
    }
}
