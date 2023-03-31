using ApiExemplo.api.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExemplo.api.Controllers
{
    //Route - é usado para acessar o controller e os metodo
    //[controller] -  
    //
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        //{parametro} - define uma rota para acessar um parametro
        //EX: [Route("metodo/teste/{id}")]
        // Para os metodo não é o suficiente para definir rotas de um metodo é necessario definir um atributo de configuração

        //[HttpGet]
        //[Route("{id}")]
        //public string GetByID(long id)
        //{return "Está funcionando!";}

        //[HttpPost]
        //[Route("pessoa/novo/{nome}")]
        //public string PostPessoa(string nome) 
        //{return "Pessoa criada!";}

        //[HttpPut]
        //[Route("pessoa/atualiza/{nome}")]
        //public string PutPessoa(string nome)
        //{return "Pessoa atualizada!";}

        //[HttpPatch]
        //[Route("pessoa/atualiza/{nome}")]
        //public string PatchPessoa()
        //{return "Pessoa atualiza!";}

        //[HttpDelete]
        //[Route("{id}")]
        //public string DeleteByID(long id)
        //{return "Pessoa deletada!";}

        private ExemploHandler handler;
        //***********************************************************************
        //Não esqueça de fazer o método contrutor pra poder ser feita a execução
        //***********************************************************************
        public ExemploController()
        {
            handler = new ExemploHandler();
        } 

        [HttpGet]
        [Route("pessoa/{id}")]
        public string GetByID(long id)
        {
            return  handler.GetByID(id);
        }
        [HttpPost]
        [Route("pessoa/novo/{nome}")]
        public string PostPessoa(string nome)
        {
            handler.PostPessoa(nome);
            return "Pessoa adiciona com sucesso!";
        }
    }
}
