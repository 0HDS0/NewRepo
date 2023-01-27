namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista ou array(Vetor) - é um aestrutura de dados que comtém uma lista de objetos.
            //Array
            string[] Frutas = new string[5];

            Frutas[0] = "Banana";
            Frutas[1] = "Tomate";

            //Sytem.Collection.Generic
            //List - Define uma lista fortemente tipada, ou seja, é preciso especificar qual tipo de que será armazendo na lista.
            List<string> Nomes;
            
            //A inicialização do list precisa ser feita através de um construtor.
            Nomes = new List<string>()
            {
                "Henrique",
                "Gustavo",
                "Fernando",
                "Elizabeth"
            };
            
            //A estrutura possui algumas propriedades que nos auxiliam no acesso dos elementos que alista armazena.
            //Da mesma maneira que no array, usamos Colchestes para acessar os elementos.
            Console.WriteLine(Nomes[0]);
            Console.WriteLine(Nomes[1]);
            Console.WriteLine(Nomes[2]);
            Console.WriteLine(Nomes[3]);

            //Count - Retorna a quantidade de elementos que a lista possui.
            Console.WriteLine("\nQuantidade de elementos: "+(Nomes.Count));

            //Add - Recebe um elemento, que será adicionado ao final da lista.
            Nomes.Add("Giovana");
            Nomes.Add("Lucian");

            //Insert - Recebe um índice e um elemento, que vai ser adicionado na lista no índice especificado.
            Nomes.Insert(2, "Franchesco Virguline viauuuuuuuu");

            


            for (int i=0; i < Nomes.Count; i++)
            {
                Console.WriteLine(Nomes[i]);
            }

            //Contains - Recebe um elemento, e verifica se esse elemento existe dentro da lista, retornando um valor booleano.
            Console.WriteLine(Nomes.Contains("Henrique"));
            Console.WriteLine(Nomes.Contains("Rafael"));

            //Remove - Recebe um elemento, que vai ser removido da lista.
            Nomes.Remove("Fernando");
            Console.WriteLine(Nomes.Contains("Fernando"));

            //RemoveAt - Recebe um  índice, que vai ser removido da lista.
            Nomes.RemoveAt(1);
            Console.WriteLine(Nomes.Contains("Gustavo"));

            //Clear - Remove todos os elementos da lista 
            Nomes.Clear();


            Console.ReadKey();
        }
    }
}