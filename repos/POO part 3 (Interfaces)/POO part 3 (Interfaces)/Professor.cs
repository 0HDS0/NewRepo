namespace POO_part_3__Interfaces_
{
    internal class Professor : IPessoa, IFuncinario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public decimal Salario { get; set; }

        public void ReceberSalario() { }

    }
}
