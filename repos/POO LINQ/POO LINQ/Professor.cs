using System.Reflection.Metadata.Ecma335;

namespace POO_LINQ
{
    internal class Professor : IPessoa
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Professor(long id, string nome, string cpf)
        {
            ID= id;
            Nome= nome;
            CPF= cpf;
        }
        public long GetID()
        {
            return ID;
        }
        public string GetNome() 
        { 
            return Nome; 
        }

        public string GetCpf() 
        { 
            return CPF; 
        } 

        public void LancarNota(double nota, string disciplina, Aluno aluno)
        {
            int cont = aluno.GetNotasByDisciplina(disciplina).Count;

            if (cont < 4)
            {
                Console.WriteLine("Todas as notas da disciplina Já foram lançadas");
                return;
            }

            RegistroNota registrarNota = new RegistroNota(123, disciplina, nota);
            aluno.AdicionarNota(registrarNota);
        }

    }
}
