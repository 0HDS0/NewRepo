namespace POO_part_3__Interfaces_
{
    internal class Soma : IOperacaoMatemetica
    {
        public void Calculo(double Valor1, double Valor2)
        {
            double Calcular = Valor1 + Valor2;
            Console.WriteLine($"O valor da soma é de {Calcular}");
        }

    }
}
