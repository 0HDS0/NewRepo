using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// É necessário as duas importações a baixo.
using System.Data;
using System.Data.SqlClient;
namespace API.SqlServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlController : ControllerBase
    {
        [HttpGet]
        [Route("Teste")]
        public ActionResult Teste()
        {
            //é definido as questões de configuração (As informações de nome do Server e Database Do SqlServer tela inicial)
            string connectionString = 
                "Server=UEP15-8820-A\\SQLEXPRESS;Database=SENAC;Trusted_Conection=True";
            //Cria a conexão enter o SqlServer e uma classe.
            SqlConnection con = new SqlConnection(connectionString);
            //Abre a a conexão
            con.Open();//USE DATABASE
            //Depois de abrir a conexão é feito os processos. e utizar Classe e tipo de dado Sql Command
            //Sql Comand recebe uma string que possui a instrução SQL que será executada
            string sql = @"
                    SELECT
                        P.ID
                        P.NOME as NOME_PRODUTO
                    FROM PRODUTO AS P";
            SqlCommand cmd = new SqlCommand(sql, con);
            //Para executar temos 2 comandos principais
            //ExecuteNonQuery - Executa a instrução mas não da retorno dos registros
            //EecuteReader - irá retornar uma instrução SQL, e irá retornar um objeto do tipo SqlDataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //É o responsavel por amazenar os resultados de um consulta.
            //Apartir do método Read - faz a leitura a próxima linha (ou execução linha a linha) é util em um while
            while (reader.Read())
            {
                //É possível usar um indice que funciona quase da mesma forma que um array podendo ser definido por indíce ou por nome
                //reader[0];//ID
                //reader[1];//Nome


                //pegar a por tipo 
                //é melhor através do tipo pois facilita na hora de adicionar em uma variavel
                int id = reader.GetInt32("ID");
                string nome = reader.GetString("NOME_PRODUTO");
                
            }
            //E é importante fechar a conexão no fim do processo.
            con.Close();

            return Ok();
        }
    }
}
