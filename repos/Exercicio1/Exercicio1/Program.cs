namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nInforme o primeiro número");
            string ValSt1 = Console.ReadLine();
            double ValNum1 = double.Parse(ValSt1);

            Console.WriteLine("\nInforme o segundo número");
            string ValSt2 = Console.ReadLine();
            double ValNum2 = double.Parse(ValSt2);

            double Adicao = ValNum1 + ValNum2;
            double Subt = ValNum1 - ValNum2;
            double Mult = ValNum1 * ValNum2;
            double Div = ValNum1 / ValNum2;

            Console.WriteLine("\nAdição: " + Adicao);
            Console.WriteLine("Subtração: " + Subt);
            Console.WriteLine("Multiplicação: " + Mult);
            Console.WriteLine("Divisão: " + Div);
            Console.ReadKey();
        }
    }
}