using Execicio4_Aula_4_.Domains;
using Execicio4_Aula_4_.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Execicio4_Aula_4_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Exc4Controller : ControllerBase
    {
        private PersonHandler handler;

        public Exc4Controller()
        {
            handler = new PersonHandler();
        }


        /* Processo síncrono e Asíncrono - No C# usamos o metodo async.
         * Dentro do método asíncrono ele é executado de forma síncrona
         * Para funcionar um metodo contínuo precisa de um outro método o Task<Tresult> Exemplo: Task<string>
         * Para alguns processos é necessário fazer um espera na execução e para isso é usado o await 
         * 
         * EX:
         * public async Task<sting> TEsteString()
         * {
         *      string texto = "";
         *      Processo!!!
         *      texto = await ValidaString(texto);
         *      Processo!!!
         *      return texto
         * }
         * 
         * public async Task<string> ValidaString(string texto)
         * {
         *      Processo!!!
         *      return texto;
         * }
         */

        [HttpGet]
        [Route("pessoa/{id}")]
        public async Task<Person> GetpessoaById(long id)
        {
            return handler.GetPessoaById(id);
        }

        [HttpPost]
        [Route("ParametroBody")]
        public async Task<string> PostPessoa([FromBody] Person person)
        {
            handler.PostPessoa(person);
            return "Pessoa adicionada com sucesso!";
        }
    }
}
