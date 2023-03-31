namespace Calculadora.Domains
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }

        public Person(long id, string name, string Cpf)
        {
            Id= id;
            Name= name;
            CPF= Cpf;
        }
    }
}
