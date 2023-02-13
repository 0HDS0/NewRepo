namespace POO_part_2
{
    internal class ClassePai
    {
        public string VariavelPublica;
        private string VariavelPrivada;
        protected string VariavelProtegida;
        public static string VariavelEstatica;
        public ClassePai()
        {
            VariavelPublica = "Qualquer coisa";
            MetodoPublico();
            VariavelPrivada = "Qualquer Coisa";
            MetodoPrivado();
            VariavelProtegida = "Qualquer Coisa";
            MetodoProtegido();
            VariavelEstatica = "Qualquer Coisa";
            MetodoEstatico();  
        }

        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
        public static void MetodoEstatico() { }
    }
}
