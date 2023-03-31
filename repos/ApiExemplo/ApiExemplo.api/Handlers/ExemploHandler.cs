using ApiExemplo.api.Domain;
using System.Security.Cryptography.X509Certificates;

namespace ApiExemplo.api.Handlers
{
    public class ExemploHandler
    {
        private static List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(1, "Henrique"),
                new Pessoa(2, "Débora"),
                new Pessoa(3, "Matheus"),
                new Pessoa(4, "Felipe"),
                new Pessoa(5, "Thiago")
        };

        
        public string GetByID(long id)
        {
            Pessoa? pessoa = pessoas.Where(pessoa => pessoa.ID== id).FirstOrDefault();
            if (pessoa == null) return "Está pessoa não existe";

            return pessoa.Nome;
                       
        }
        public void PostPessoa(string nome)
        {
            long id = pessoas.Count + 1;
            Pessoa pessoa = new Pessoa(id, nome);

            pessoas.Add(pessoa);
        }
    }
}
