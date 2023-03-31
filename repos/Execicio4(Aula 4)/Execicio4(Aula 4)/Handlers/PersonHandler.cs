using Execicio4_Aula_4_.Domains;

namespace Execicio4_Aula_4_.Handlers
{
    public class PersonHandler
    {
        private static List<Person> Persons = new List<Person>()
            {
                 new Person (1,"Henrique","111111111111",20, "11.111.111-11")
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
