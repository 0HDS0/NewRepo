namespace POO_part_3__Interfaces_
{
    public interface IFiguraGeometrica
    {
        double Altura { get; set; }
        double Largura { get; set; }

        void CalcularArea();
        
    }
}
