using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Projeto_Aula06_.Domain
{
    //**********************************************************
    //Serialização - é converter um objeto em um Json
    //Deserialização - é o inverso da serialização

    //*****************************************************************************************
    //C# - ja tem atributos de configuração para realizar esse processo mas usaremos um externo:
    //NuGet - é um gerenciador de pacotes, utilizando para compartilhar e gerenciar bibliotecas de cógigo
    //instalação e gerenciamento é feita por projeto

    //**********************************************************
    //Se for usado no MerberSerialization OptOut todos os atributos public a menos que tenha [JsonIgnore] serão considerados no Json já os private não irão fazer parte do Json

    //****************************************************************************************************************************************************************************
    //Se for usado no MerberSerialization Fields todos os atributos serão considerados no Json a menso que tenha [JsonIgnore]

    //****************************************************************************************************************************************************************************
    //Se for usado no MerberSerialization OptIn para selecionar um atributo é necessário usar [JsonPropertyName] e permite receber uma string para definir um nome diferente do JSon

    public class Pessoa
    {
        [JsonPropertyName("id_pessoa")]
        public long ID { get; set; }

        [JsonPropertyName("nome")]
        public string Nome{ get; set; }

        [JsonPropertyName("cpf_cnpj")]
        public string CPF{ get; set;}
    }
}
