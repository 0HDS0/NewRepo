using AULA_07.Domain;
using AULA_07.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AULA_07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private EnderecoHandler handler;

        public EnderecoController()
        {
            handler = new EnderecoHandler();
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<Endereco> GetById(long id)
        {
            return handler.GetById(id);
        }

        [HttpPost]
        [Route("new")]

        public async Task<string> PostEndereco([FromBody]Endereco adress)
        {
            handler.PostEndereco(adress);
            return "Endereço cadastrado com sucesso";
        }
    }
}
