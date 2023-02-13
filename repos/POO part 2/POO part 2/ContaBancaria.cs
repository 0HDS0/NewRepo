namespace POO_part_2
{
    public class ContaBancaria
    {

        protected int NDaConta;
        protected int NDaAgencia;
        protected decimal Saldo;
        public ContaBancaria(int ndaconta, int ndaagencia)
        {
            NDaConta = ndaconta;

            NDaAgencia = ndaagencia;

            Saldo = 0;
        }
        public void Sacar(decimal valor) { Saldo -= valor; }
        public void Depositar(decimal valor) { Saldo += valor; }


        public void ExibirSaldo()
        {
            Console.WriteLine(Saldo);
        }
        public void VisualizarNumeroDaAgencia()
        {
            Console.WriteLine(NDaAgencia);
        }
        public void VisualizarNumeroDaConta()
        {
            Console.WriteLine(NDaConta);
        }

        //Getter e Setter
        public void SetNDaConta(int nDaConta)
        {
            NDaConta = nDaConta;
        }
        public decimal GetSaldo()//Get é responsavel por permitir a visualização da informação
        {
            return Saldo;
        }

    }
}
