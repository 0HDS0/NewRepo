using Aula18.Domain;
using Aula18.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula18.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private PessoaHandler handler;
        public PessoaController()
        {
            handler = new PessoaHandler();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(long id)
        {
            return handler.Handle(id);
        }
        [HttpPost]
        [Route("novo")]
        public async Task<IActionResult> Post([FromBody] Pessoa pessoa)
        {
            return handler.Handle(pessoa);
        }
        [HttpGet]
        [Route("teste")]
        public async Task<IActionResult> Teste()
        {
            return Ok("Está funcionando");
        }
        [HttpPost]
        [Route("teste")]
        public async Task<IActionResult> Teste([FromBody] Pessoa pessoa)
        {
            return Ok(pessoa);
        }
    }
}
