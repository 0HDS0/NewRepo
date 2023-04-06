using System.Text.Json.Serialization;

namespace Aula18.Domain
{
    public class Pessoa
    {
        [JsonPropertyName("id")]
        public long ID { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
