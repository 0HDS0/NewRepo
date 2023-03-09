namespace POO_part_3__Interfaces_
{
    internal class Retangulo : IFiguraGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double largura,double altura)
        { 
            Largura= largura;
            Altura= altura;
        }

        public void CalcularArea() 
        {

            double calculo = Altura * Largura;
            Console.WriteLine($"A area de um Retângulo de altura {Altura} e largura {Largura} é de {calculo}");
        }

    }
}
