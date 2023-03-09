namespace POO_LINQ
{
    public class RegistroNota
    {

        private long ID;
        private string Disciplina;
        private double Nota;

        public RegistroNota(long id, string disciplina, double nota)
        {
            ID = id;
            Disciplina = disciplina;
            Nota = nota;
        }

        public long GetID() { return ID; }
        public string GetDisciplina() { return Disciplina; }
        public double GetNota() { return Nota; }

    }
}
