using ExercicioAula_9.Domain;
using ExercicioAula_9.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioAula_9.Controllers
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
        public async Task<Pessoa> GetByID(long id)
        {
            return handler.GetById(id);
        }
        [HttpPost]
        [Route("new")]
        public async Task<string> Post([FromBody] Pessoa pessoa)
        {
            handler.Post(pessoa);
            return "Pessoa cadastrada com sucesso";
        }
        [HttpGet]
        [Route("{id}/enderecos")]
        public async Task<List<Endereco>> GetEnderecosByID(long id)
        {
            return handler.GetEnderecoByID(id);
        }
        [HttpPost]
        [Route("{id}/enderecos/new")]
        public async Task<string> PostEnderecoByID(long id, [FromBody] Endereco endereco)
        {
            handler.PostEnderecoByID(id, endereco);
            return "Endereco cadastrado com sucesso";
        }
    }
}
