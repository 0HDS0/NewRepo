using ExercicioAula_9.Domain;
using System.Collections.Generic;

namespace ExercicioAula_9.Handlers
{
    public class PessoaHandler
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        public Pessoa GetById(long id)
        {
            Pessoa? person = pessoas.Where(person => person.ID == id).FirstOrDefault();
            return person;
        }
        public void Post(Pessoa pessoa) 
        {
            pessoas.Add(pessoa);
        }
        //Para fazer o retorno de um atributo expecifico usar ."Nome do atributo"
        public List<Endereco> GetEnderecoByID(long id)
        {
            Pessoa pessoa = pessoas.Where(adress => adress.ID == id).FirstOrDefault();
            return pessoa.Enderecos;
        }
        public void PostEnderecoByID(long id, Endereco endereco)
        {
            Pessoa pessoa = pessoas.Where(adress=>adress.ID == id).FirstOrDefault();
            pessoa.Enderecos.Add(endereco);
        }
    }
}
