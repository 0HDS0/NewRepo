namespace Vida_e_dano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina a vida do personagem");
            double Vida = double.Parse(Console.ReadLine());
            Console.WriteLine("Dano recebido");
            double Dano = double.Parse(Console.ReadLine());


            if (Vida > Dano)
            {
                Vida = Vida - Dano;
                Console.WriteLine("\nO personagem Sobreviveu");
                Console.WriteLine("Vida: " + Vida);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nO personagem morreu");
                Console.ReadKey();
            }
        }
    }
}