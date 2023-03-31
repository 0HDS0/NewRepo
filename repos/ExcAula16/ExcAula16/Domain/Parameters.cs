using ExcAula16.Enums;
using System.Reflection.Emit;
using System.Text.Json.Serialization;

namespace ExcAula16.Domain
{
    public class Parameters
    {
        [JsonPropertyName("Valor_1")]
        public double Value1 { get; set; }
        [JsonPropertyName("Valor_2")]
        public double Value2 { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("Operacoes")]
        public OperationType Operation { get; set; }
    }
}
