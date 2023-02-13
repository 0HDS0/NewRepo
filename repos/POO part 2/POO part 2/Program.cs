namespace POO_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ClassePai pai = new ClassePai();

             pai.VariavelPublica = "Qualquer coisa";
             pai.MetodoPublico();

             pai.VariavelPrivada = "Qualquer coisa";
             pai.MetodoPrivado();

             pai.VariavelProtegida = "Qualquer Coisa";
             pai.MetodoProtegido();

             pai.VariavelEstatica = "Qualquer Coisa";
             pai.MetodoEstatico();

             ClassePai.MetodoEstatico();
             ClassePai.VariavelEstatica = "Qualquer Coisa";*/

            /*Veiculo veiculo = new Veiculo();
            veiculo.Acelerar(2);
            veiculo.VelocidadeImprimir();
            veiculo.Freiar(5);
            veiculo.VelocidadeImprimir();*/

            ContaBancaria Itau = new ContaBancaria(1111111, 726);

            Itau.Depositar(2000);
            Itau.Sacar(1500);


            Itau.VisualizarNumeroDaConta();
            Itau.VisualizarNumeroDaAgencia();

            //Get e Set
            decimal saldo = Itau.GetSaldo();
            Console.WriteLine(saldo);
        }
    }
}