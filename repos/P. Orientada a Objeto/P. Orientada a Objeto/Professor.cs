namespace P._Orientada_a_Objeto
{
    internal class Professor : Pessoa
    {
        public int PisConfis;
        public int NumFilhos;
        public string EstadoCV;
        public string Curricullum;
        public string PadraoDeAulas;
        public double Salario;
        public double ValeAlimentação;
        public string PlanoDeSaúde;
        public string Departamento;
        public string StatusPsic;
        public List<string> HistoricoCriminal;
        public List <string> HistóricoAcad = new List <string> ();

        public List<string> Turmas = new List<string>()
        { "1°A","1°B","2°A","2°B","3°A","3°B"};

        public void FazerChamada() { }
        public void LancarNota() { }
        public void AplicarNota() { }
        public void BaterPonto() { }
        public void AplicarAdvertência() { }

            
    }
}
