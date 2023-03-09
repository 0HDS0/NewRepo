using System.Net.Http.Headers;

namespace POO_LINQ
{
    public class Aluno : IPessoa
    {
        public Aluno(long id, string nome, string cpf)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;

        }

        public long ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        private List <RegistroNota> registrarNotas = new List<RegistroNota>();
        public long GetID() { return ID; }
        public string GetNome() { return Nome; }
        public string GetCPF() { return CPF; }

        public void AdicionarNota(RegistroNota Nota)
        {
            registrarNotas.Add(Nota);

        }
         public List<RegistroNota> GetNotasByDisciplina(string disciplina)
        {
            return registrarNotas
                .Where(materia => materia.GetDisciplina() == disciplina)
                .ToList();
        }
        public string GetResultadoByDiscliplina(string disciplina)
        {
            List<RegistroNota> notasFiltradas = GetNotasByDisciplina(disciplina);
            if (notasFiltradas.Count < 4) return "Não existe notas suficientes para o calculo!";
            
            double Total = 0;
            foreach(RegistroNota nota in notasFiltradas)
            {
                Total += nota.GetNota();
            }
            double Media = Total / 4d;

            if (Media >= 7.0) return "Aluno aprovado!";
            else return "Aluno Reprovado!";
            
            
        }



    }
}
