using System.Text.Json.Serialization;

namespace AULA11.Domain
{
    public class Category
    {
        [JsonPropertyName("id_cat")]
        public long ID { get; set; }
        [JsonPropertyName("desc_cat")]
        public string Description { get; set; }

    }
}
