using System.Security.Cryptography.X509Certificates;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro");
            string Numtex = Console.ReadLine();
            int NumBase = int.Parse(Numtex);

            List<int> Tabuada = new List<int>()
            {
                1*NumBase,
                2*NumBase, 
                3*NumBase,
                4*NumBase,
                5*NumBase,
                6*NumBase,
                7*NumBase, 
                8*NumBase,
                9*NumBase,
                10*NumBase
            };
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n"+NumBase + "X" + i + " = ");
                Console.WriteLine(Tabuada[i]);
            }

            //Resolução do professor
            //$ - Formata a string


            Console.WriteLine("\nInforme um número: ");
            int Numero = int.Parse(Console.ReadLine());

            List<int> operandos = new List<int>()
            {1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine($"\nTabuada do número{Numero}\n");

            for (int i = 0; i < operandos.Count; i++)
            {
                int Multi = operandos[i] * Numero;

                Console.WriteLine($"\n {NumBase} X {operandos[i]} = {Multi}");
            }

            Console.WriteLine("\nPressione uma tecla");
            Console.ReadKey();
        }
    }
}