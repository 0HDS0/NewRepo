using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Aula06_.Domain;

namespace Projeto_Aula06_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        [Route("new")]
        public Pessoa PostPessoa([FromBody] Pessoa pessoa)
        {
            return pessoa;
        }
    }
}
