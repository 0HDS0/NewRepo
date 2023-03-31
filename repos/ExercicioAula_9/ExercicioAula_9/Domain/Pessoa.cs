using System.Text.Json.Serialization;

namespace ExercicioAula_9.Domain
{
    public class Pessoa
    {
        [JsonPropertyName("id_pes")]
        public long ID { get; set; }

        [JsonPropertyName("nome_pes")]
        public string Nome { get; set; }

        [JsonPropertyName("cpf_pes")]
        public string CPF { get; set; }

        [JsonPropertyName("data_nasc")]
        public DateTime DataNascimento { get; set; }

        [JsonPropertyName("list_end")]
        public List<Endereco>? Enderecos { get; set; }

        public Pessoa()
        {
            Enderecos= new List<Endereco>();
        }
     
    }
}
