using System.Text.Json.Serialization;

namespace AULA11.Domain
{
    public class Product
    {
        [JsonPropertyName("id_produto")]
        public long ID { get; set; }

        [JsonPropertyName("nome_produto")]
        public string Name { get; set; }

        [JsonPropertyName("val_produto")]
        public DateTime Validity { get; set; }

        [JsonPropertyName("idcat_produto")]
        public long IDCategory { get; set; }

        [JsonPropertyName("category_produto")]
        public Category? Category { get; set; }
    }
}
