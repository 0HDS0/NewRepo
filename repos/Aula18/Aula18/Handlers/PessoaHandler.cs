using Aula18.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Aula18.Handlers
{
    public class PessoaHandler
    {
        public static List<Pessoa> pessoas = new List<Pessoa>();
        public IActionResult Handle(long id)
        {
            Pessoa? pessoa= pessoas.Where(X => X.ID == id).FirstOrDefault();
            if (pessoa == null)
            {
                return new NotFoundObjectResult($"A pessoa de id {id} não existe");
            }
            return new ObjectResult(pessoa);
        }
        public IActionResult Handle(Pessoa pessoa)
        {
            Pessoa? pessoaExiste = pessoas.Where(X => X.ID == pessoa.ID).FirstOrDefault();
            if (pessoaExiste != null)
            {
                return new ConflictObjectResult($"A pessoa de id {pessoa.ID} já existe");
            }
            pessoas.Add(pessoa);
            return new CreatedResult($"api/pessoa/{pessoa.ID}", pessoa);
        }
    }
}
