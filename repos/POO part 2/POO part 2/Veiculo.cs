namespace POO_part_2
{
    public class Veiculo
    {
        protected int Velocidade = 0;

        public void Acelerar(int velocidade)
        { Velocidade = Velocidade + velocidade; }

        public void Freiar(int velocidade)
        { Velocidade = Velocidade - velocidade; }

        public void VelocidadeImprimir() { Console.WriteLine(Velocidade); }
    }
}
