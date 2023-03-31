using AULA_07.Domain;

namespace AULA_07.Handlers
{
    public class EnderecoHandler
    {   
        //**********************************************************
        // Lembrar adicionar "static" as listas para não dar erro
        //**********************************************************
        private static List<Endereco> enderecos = new List<Endereco>();
        
        public Endereco GetById(long id)
        {
            Endereco adress = enderecos.Where(adress => adress.ID == id).FirstOrDefault();
            return adress;
        }

        public void PostEndereco(Endereco adress)
        {
            enderecos.Add(adress);
        }


    }
}
