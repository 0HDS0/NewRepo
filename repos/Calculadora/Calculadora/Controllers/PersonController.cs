using Calculadora.Domains;
using Calculadora.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private PersonHandler handler;

        public PersonController() 
        {
            handler = new PersonHandler();
        }
        [HttpGet]
        [Route("pessoa/{id}")]
        public Person GetpessoaById(long id)
        {
            return handler.GetPessoaById(id);
        }

        [HttpPost]
        [Route("new")]
        public string PostPessoa
            (
            [FromQuery] long id,
            [FromQuery] string name,
            [FromQuery] string cpf
            )
        {
            //handler.PostPessoa(name, cpf);
            return "Pessoa adicionada Com sucesso!";
        }
    }
}
