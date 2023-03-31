using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        [Route("StatusCode200")]
        public IActionResult StatusCode200()
        {
            List<string> result = new List<string>()
            {
                "Se essa rua, se essa rua fosse minha",
                "Eu mandava, eu mandava ladrilhar",
                "Com pedrinhas, com pedrinhas de brilhante",
                "Para o meu, para o meu amor passar"
            };
            //OK() - Retorna um código 200 que pode retornar qualquer tipo de informação
            return Ok(result);
        }
        [HttpPost]
        [Route("StatusCode201")]
        public IActionResult PostStatusCode201()
        {
            //Criamos uma pessoa
            //api/pessoa/Novo - POST
            //api/pessoa/{id} - GET

            // Created() - Retorna um código 201 e
            // é usado a routa do GET como um dos parametros

            return Created
                (
                "api/pessoa/1",
                //Pode se retornar uma string ou um objeto Ex:Pessoa
                "Pessoa cadastrada com sucesso!"
                );
        }

        /*Accepted() - Retorna um código 202 e
        também podemos adicionar um parametro a ele
        **********************************************************************
        EX Rota:return Accepted("api/pessoa/1");
        **********************************************************************
        EX Objeto: return Accepted(false); - esse estará no corpo da reposta
        **********************************************************************
        EX Rota & Objeto: return Accepted("api/pessoa/1", "Objeto pessoa");
        **********************************************************************
        EX Vazio:*/
        [HttpPost]
        [Route("StatusCode202")]
        public IActionResult PostStatusCode202()
        {
            return Accepted();
        }
        [HttpDelete]
        [Route("StatusCode204")]
        public IActionResult DeleteStatusCode201()
        {
            //Nocontent() - Retorna um código 204 e
            //não retorna conteúdo
            return NoContent();
        }
        //Redirect() - retorna os códigos 301,302,307,308 e
        //retorna um parametro obrigatório e dois outros não obrigatórios
        //Entre os não obrigatórios que devem ser booleanos
        //O primeiro indica o redirecionamento é permanente ou não
        //Então se ele for RedirectPermanent() o código retornado vai ser 301, se Redirect() 302
        //E o segundo parametro indica se o metodo HTTP vai ser alterado ou não
        //Então se o for RedirectPreserveMethod() retorna 307 e
        //Se for RedirectPermanentPreserveMethod() retorna o código 307

        [HttpPut]
        [Route("StatusCode301")]
        public IActionResult PutStatusCode301()
        {
            return RedirectPermanent("StatusCode301Atualizado");
        }

        [HttpPatch]
        [Route("StatusCode302")]
        public IActionResult PutStatusCode302()
        {
            return Redirect("StatusCode301Atualizado");
        }

        [HttpGet]
        [Route("StatusCode307")]
        public IActionResult PutStatusCode307()
        {
            return RedirectPreserveMethod("StatusCode307Update");
        }
        [HttpDelete]
        [Route("StatusCode308")]
        public IActionResult DeleteStatusCode308()
        {
            return RedirectPermanentPreserveMethod("StatusCode308Update");
        }

        //BadRequest - retrona o código 400
        //Pode ser definido um parametro
        //Ex:return Unauthorized(Qualquer parametro);
        [HttpPatch]
        [Route("StatusCode400")]
        public IActionResult PatchStatusCode400() 
        {
            return BadRequest("Deu erro amigo!");
        }

        //Unauthorized() - retorna o código 401(Não autenticado)
        //Pode ser definido um parametro
        //Ex:return Unauthorized(Qualquer parametro);
        [HttpGet]
        [Route("StatusCode401")]
        public IActionResult GetStatusCode401()
        {
            return Unauthorized("Não autenticado");
        }

        //NotFound() - retorna o código 404
        //Pode ser definido um parametro
        //Ex:  return NotFound(Qualquer parametro);
        [HttpPost]
        [Route("StatusCode404")]
        public IActionResult PostStatusCode404()
        {
            return NotFound("Você achou um link morto!");
        }

        //Conflict() - retorna o código 409
        //Pode ser definido um parametro
        //Ex:return Unauthorized(Qualquer parametro);
        [HttpPut]
        [Route("StatusCode409")]
        public IActionResult PutStatusCode409()
        {
            List<double> troubles = new List<double>()
            {
                1.2,
                2.3,
                3.4
            };

            return Conflict(troubles);
        }

        //StatusCode() - recebe um int como parametro que será o cógigo
        [HttpGet]
        [Route("StatusCode")]
        public IActionResult GetStatusCode()
        {
            //Pode ser passado um  objeto para definir o corpo da resposta
            //EX: return StatusCode(500, "Erro de servidor");
            return StatusCode(500);
        }

    }
}
