using Calculadora.Domains;

namespace Calculadora.Handlers
{
    public class PersonHandler
    {
        private static List<Person> Persons = new List<Person>()
            {
                 new Person (1,"Henrique","111111111111")
            };


        public Person GetPessoaById(long id)
        {
            Person? person = Persons.Where(person => person.Id == id).FirstOrDefault();
            
            //if (person == null) return "Está pessoa não existe";
            
            return person;
        }

        public void PostPessoa(Person person)//(string name, string cpf)
        {
            //long id = Persons.Count + 1;
            //Person pessoa = new Person(id, name, cpf);
            
            Persons.Add(person);

        }
    }
}
