
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using ProductSql.API.Domain;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProductSql.API.Handlers
{
    public class ProdutoHandler
    {
        private string connectionString =
               "Server=UEP15-8820-A\\SQLEXPRESS; Database=API_CSHARP; Trusted_Connection=True";
        public Produto GetbyID(int id)
        {
            SqlConnection Unico = new SqlConnection(connectionString);
            Unico.Open();
            string Sql = @$"
                SELECT
                P.ID,
                P.NOME,
                P.CATEGORIA,
                P.VALOR
                FROM PRODUTO AS P
'               WHERE {id} = ID";
            SqlCommand cmd = new SqlCommand(Sql, Unico);
            SqlDataReader reader = cmd.ExecuteReader();

            Produto produto = new Produto();

            if (reader.Read())
            {
                string nome = reader.GetString("NOME");
                string categoria = reader.GetString("CATEGORIA");
                double valor = Convert.ToDouble(reader.GetDecimal("VALOR"));

                produto.Id = id;
                produto.Nome = nome;
                produto.Categoria = categoria;
                produto.Valor = valor;
            }
            
            Unico.Close();
            return produto;
        }

        public List<Produto> GetAll()
        {
            SqlConnection Lista = new SqlConnection(connectionString);
            Lista.Open();
            string Sql = @"
                SELECT
                P.ID,
                P.NOME,
                P.CATEGORIA,
                P.VALOR
                FROM PRODUTO AS P";
            SqlCommand cmd = new SqlCommand(Sql, Lista);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Produto> produtos = new List<Produto>();
            while (reader.Read())
            {
                Produto produto = new Produto();

                produto.Id = reader.GetInt32("ID");
                produto.Nome = reader.GetString("NOME");
                produto.Categoria = reader.GetString("CATEGORIA");
                produto.Valor = Convert.ToDouble(reader.GetDecimal("VALOR"));
                produtos.Add(produto);
            }
            Lista.Close();
            return produtos;
        }

        public void Post(Produto produto)
        {
            SqlConnection post = new SqlConnection(connectionString);
            post.Open();
            string Sql = @$"
                INSERT INTO PRODUTO (ID,NOME,CATEGORIA,VALOR)
                VALUES (
                {produto.Id},
                '{produto.Nome}',
                '{produto.Categoria}',
                {produto.Valor.ToString().Replace(",",".")})";
            SqlCommand cmd = new SqlCommand(Sql, post);
            cmd.ExecuteNonQuery();

            post.Close();
        }
    }
}
