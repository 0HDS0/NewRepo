using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach - Define um bloco de código que é executado uma vez para cada elemento de uma listaSendo compodto de: Elemento e coleção
            Console.WriteLine("Foreach");
            List<int> Numeros = new List<int>()
            { 1,2,3,4,5,6,7,8,9,10};

            foreach (int i in Numeros)
            {
                Console.WriteLine(i);
            }

            // Exercicio 3

            Console.WriteLine("\nExercicio 3\n");
            

            List<double> Calculo = new List<double>(); 
            while (Calculo.Count < 5)
            {
                Console.WriteLine("Informe um número");
                double Elemento = double.Parse(Console.ReadLine());
                Calculo.Add(Elemento);
            }
            double Soma = 0;

            foreach (double ints in Calculo)
            {
                Soma += ints;
            }
            Console.WriteLine($"\nA soma dos números é: {Soma}");
           
            
            //Exercicio 4


            List<int> paraemento= new List<int>();
            while (paraemento.Count < 10)
            {
                Console.WriteLine("Informe um número inteiro");
                int Numero = int.Parse(Console.ReadLine());
                paraemento.Add(Numero);
            }

            int pares = 0;
            int impares = 0;

            foreach (int i in paraemento)
            {
                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

             }
            Console.WriteLine($"A quantidade números impares são {impares} e de números pares são {pares}");
            Console.ReadKey();
        }
    }
}