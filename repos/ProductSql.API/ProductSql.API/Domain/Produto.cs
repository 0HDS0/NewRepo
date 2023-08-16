namespace ProductSql.API.Domain
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string? Categoria { get; set; }

        public double Valor { get; set; }
    }
}
