namespace ExercicioAula19
{
    public class Pessoa
    {
        public Pessoa(long id, string nome, string cpf, string dataNascimento, Endereco endereco) 
        { 
            ID = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;

        }
        protected long ID;
        protected string Nome;
        protected string Cpf;
        protected string DataNascimento;
        protected Endereco Endereco;

        public long GetID() { return ID; }
        public string GetNome() { return Nome; }
        public string GetCpf() { return Cpf; }
        public string GetDataNascimento() { return DataNascimento; }
        public Endereco GetEndereco() { return Endereco; }
        public void SetEndereco(Endereco endereco) 
        { Endereco = endereco; }
    }
}
