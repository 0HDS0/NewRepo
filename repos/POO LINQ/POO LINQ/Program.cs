namespace POO_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Where -  O where funciona como um foreach, serve para filtrar os componentes de uma LIST é um recurso do C#
            //No where é baseado em 2 parametros variavel e condição 
            List<string> Frutas = new List<string>()
            {
                "Banana","Maçã","Morango","Manga","Uva","Goiaba","Pera","Laranja"
            };

            
            List<string> FrutasFiltradas = Frutas.Where(fruta => fruta.Length == 4).ToList();

            /*(=>)Arrow function 
             * Where Pode receber uma condição(Variavel => Condição)
             * Metodos(StartWith, Lenght, Contains, EndWith)*/

            foreach (string fruta in FrutasFiltradas)
            {
                Console.WriteLine(fruta);
            }
            List<Pessoa> pessoas= new List<Pessoa>();
            List<Pessoa> pessoa = pessoas.Where(pessoa => pessoa.Nome == "joaquim").ToList();
        }
    }
}