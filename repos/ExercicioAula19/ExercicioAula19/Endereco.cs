namespace ExercicioAula19
{
    public class Endereco
    {
        public Endereco
            (long id, string logradouro, string bairro, int numero, string cep, string complemento, string cidade, string estado)
        {
            ID= id;
            Logradouro= logradouro;
            Bairro= bairro;
            Numero= numero;
            Cep= cep;
            Complemento= complemento;
            Cidade= cidade;
            Estado = estado;

        }
        private long ID;
        private string Logradouro;
        private string Bairro;
        private int Numero;
        private string Cep;
        private string Complemento;
        private string Cidade;
        private string Estado;

        public long GetID() { return ID; }

        public string GetLogradouro() { return Logradouro; }

        public string GetBairro() { return Bairro; }

        public int GetNumero() { return Numero; }

        public string GetCep() { return Cep; }

        public string GetComplemento() { return Complemento; }

        public string GetCidade() { return Cidade; }

        public string GetMunicipio() { return Estado; }

        public void SetComplemento(string complemento)
        { Complemento = complemento; }
    }
}
