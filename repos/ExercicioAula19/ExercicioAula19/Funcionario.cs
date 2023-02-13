namespace ExercicioAula19
{
    internal class Funcionario:Pessoa
    {
        public Funcionario(long numeroRegistro, decimal salario,long id,string nome, string cpf, string dataNascimento, Endereco enderco):
            base(id,nome,cpf,dataNascimento,enderco)
             
        { 
            NumeroRegistro= numeroRegistro;
            Salario= salario;
        }
        private long NumeroRegistro;
        private decimal Salario;

        public long GetNumeroRegistro()
        { return NumeroRegistro;}
        public decimal GetSalario() 
        { return Salario; }
        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }
    }
}
