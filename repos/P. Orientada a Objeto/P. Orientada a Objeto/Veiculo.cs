namespace P._Orientada_a_Objeto
{
    public class Veiculo
    {
        public string Modelo;
        public string Motor;
        public string Placa;

        public void Ligar() 
        {
            Console.WriteLine("O veiculo está ligado");
        }

        public void Acelerar()
        {
            Console.WriteLine("O veiculo está acelerando");
        }
    }
}
