namespace POO_part_3__Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface - É como um contrato a qual está atrelada, pois define atributos que a classe vai ter 
            //e para definir esses atributos é usado os acessadorres get e set EX: { get;set; }

            /*Professor professor = new Professor();

            professor.Nome = "";
            professor.CPF = "";
            professor.Salario = 0;
            professor.ReceberSalario();*/

             Quadrado quadrado = new Quadrado(20);
             Retangulo retangulo = new Retangulo(10, 20);
             Triangulo triangulo = new Triangulo(15,34);

             quadrado.CalcularArea();
             retangulo.CalcularArea();
             triangulo.CalcularArea();

            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();
            Subtracao subtracao = new Subtracao();
            Soma soma = new Soma();

            multiplicacao.Calculo(2,2);
            divisao.Calculo(2,2);
            subtracao.Calculo(2,2);
            soma.Calculo(2,2);

        }
    }
}