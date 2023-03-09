using System.Security.Cryptography.X509Certificates;

namespace POO_part_3__Interfaces_
{
    internal class Triangulo : IFiguraGeometrica
    {
        public Triangulo(double largura, double altura) 
        {
            Largura= largura;
            Altura= altura;
        }
        public double Largura { get;set; }
        public double Altura { get;set; }

        public void CalcularArea()
        {
            double calculo = Altura * Largura/2;
            Console.WriteLine($"A area de um Triângulo de altura {Altura} e de largura {Largura} é de {calculo}");
        }
    }
}
