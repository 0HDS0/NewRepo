using Aula14.Enums;
using System.Text.Json.Serialization;

namespace Aula14.Domain
{
    public class Servico
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("status")]
        public StatusServico status { get; set; }
        public Servico()
        {
            status = StatusServico.Emprogresso;
        }
    }
}
