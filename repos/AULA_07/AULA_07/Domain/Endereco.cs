using System.Text.Json.Serialization;

namespace AULA_07.Domain
{
    public class Endereco
    {
        [JsonPropertyName("id_end")]
        public long ID { get; set; }

        [JsonPropertyName("desc_end")]
        public string Descricao { get; set; }

        [JsonPropertyName("rua_end")]
        public string Logradouro { get; set; }

        [JsonPropertyName("num_end")]
        public int Numero { get; set; }

        [JsonPropertyName("comp_end")]
        public string Complemento { get; set; }

        [JsonPropertyName("cid_end")]
        public string Cidade { get; set; }

        [JsonPropertyName("est_end")]
        public string Estado { get; set;}


    }
}
