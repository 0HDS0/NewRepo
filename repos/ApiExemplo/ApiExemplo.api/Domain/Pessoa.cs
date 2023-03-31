namespace ApiExemplo.api.Domain
{
    public class Pessoa
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public Pessoa(long id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}
