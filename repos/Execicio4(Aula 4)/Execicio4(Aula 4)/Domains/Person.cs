using System.Text.Json.Serialization;

namespace Execicio4_Aula_4_.Domains
{
    public class Person
    {
        [JsonPropertyName("id_person")]
        public long Id { get; set; }

        [JsonPropertyName("nome_cp")]
        public string Name { get; set; }

        [JsonPropertyName("cpf_cnpj")]
        public string CPF { get; set; }

        [JsonPropertyName("idade")]
        public int Age { get; set; }

        [JsonPropertyName("rg_nacional")]
        public string RG { get; set; }

        public Person() { }

        public Person(long id, string name, string cpf,int idade, string rg)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Age = idade;
            RG = rg;

        }
    }
}
