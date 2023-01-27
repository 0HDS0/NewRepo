namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NumTex = Console.ReadLine();
            int Num = int.Parse(NumTex);
            //if,else
            //(.Trim) remove os espaços das bordas
            if (!String.IsNullOrEmpty(NumTex.Trim()))
            {
                Console.WriteLine(Num);
            }
            else
            {
                Console.WriteLine("É o brigatório informar um número");
            }
            //Switch - é um tipo de caso
            switch (Num)
            {
                case 0: Console.WriteLine("O número igual a zero");
                    break; 
                case 1: Console.WriteLine("O número é igual a um");
                    break; 
                default: Console.WriteLine("O número é maior que um");
                    break;
            }
            //While - Enquanto
            while (Num> 0)
            {
                Console.WriteLine(Num);
                Num--;
            }
            //Do - Faça
            do
            {
                Console.WriteLine(Num);
                Num--;
            } while (Num > 0);
            //For - Para
            for(int i = 0; i <= 10;i++)
            {
                Console.WriteLine(i);
            }


                Console.ReadKey();
        }
    }
}