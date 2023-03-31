using Calculadora.Domains;
using Calculadora.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Calculadora.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        //Parametro Route
        [HttpGet]
        [Route("ParametroRota/{text}")]
        public string ParametroRota(string text)
        {
            return text;
        }

        //Parametro query - aparecem no fim da URL sendo separado por ? depois
        //São definidos no metodo que recebe a rota mas não é necessário na rota

        [HttpGet]
        [Route("ParametroQuery")]

        public string ParamQuery([FromQuery]string text, [FromQuery]int Age)
        {
            return text;
        }


        //Parametro Body - É onde será informado os parâmetros de corpo


        private PersonHandler handler;

        public ExemploController()
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
        [Route("ParametroBody")]
        public string PostPessoa([FromBody] Person person)
        {
            handler.PostPessoa(person);
            return "Pessoa adicionada com sucesso!";
        }







        /*JSON(JavaScript Object Notation) - é um objeto baseado em texto, sem schema, baseado em pares de chave-valores
        *Sem schema - não tem uma estrutura que precisa seguir de forma exata
        *Baseado em pares de chaves-valores - precisam seguir um padrão de chave valor, deve existir um nome único
        *para aquela informação seguido de um valor para aquela informação. Cada um dos pares deve ser separado por virgula
        *e todos devem estar dentro de chaves {}.
        */
    }
}
