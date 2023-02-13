namespace P._Orientada_a_Objeto
{
    internal class Aluno : Pessoa
    {

        public List <String> Materias = new List <String>() 
        {"Português","Inglês","Matemática","Biologia","Filosofia","Sociologia"};
        public List<int> Notas = new List<int>() {0,0,0,0};
        public DateTime DataMatricula;
        public string Curso;
        public List<string> HistóricoEscolar;
        public List<string> Frequencia;
        public string Semestre; 

        public void AcessoNotas() { }
        public void VisualizarFrequencia() { }
        public void VisualizarCalendarioAcademico() { }
        public void AnexarAtestado() { }
    }
}
