namespace POO_part_3__Interfaces_
{
    public class Quadrado: IFiguraGeometrica
    {
        public Quadrado(double lado)
        {
            Altura = lado;
            Largura = lado;
        }

        public double Altura { get; set; }
        public double Largura { get; set; }

        public void CalcularArea() 
        {
            
            double calculo = Altura * Largura;
            Console.WriteLine($"A area de um quadrado de lado {Altura} é de {calculo}");
        }
    }
}
