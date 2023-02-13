namespace P._Orientada_a_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Motor motorSaveiro = new Motor();

            motorSaveiro.Cilindros = "4";
            motorSaveiro.CavalosDeForca = "115";
            motorSaveiro.TipoCombustível = "Gasolina";

            Carro Saveiro = new Carro("Saveiro 2023", "Rosa", motorSaveiro, 2, "15 polegadas", true);

            Saveiro.Acelerar();
            Saveiro.Freiar();
            Saveiro.LigarAluz();*/

            Veiculo veiculo= new Veiculo();
            Carro carro = new Carro();
            Moto moto = new Moto();

            veiculo.Modelo = "Gol quadrado";
            veiculo.Ligar();

            carro.Modelo = "Eclipse";
            carro.Ligar();

            moto.Modelo = "Yamaha";
            moto.Ligar();

        }
        

    }
}