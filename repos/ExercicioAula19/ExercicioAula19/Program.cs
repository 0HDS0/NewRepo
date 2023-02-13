namespace ExercicioAula19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Endereco Casa = new Endereco(213, "Rua franquilin","Santa maria",544,"11111-111","Casa azul","Blumenal","Santa Catarina" );
            Funcionario João = new Funcionario(67464674, 2487.93m, 213, "João Mauricio", "12345678901", "23/12/74", Casa);
            
            
        }
    }
}