namespace Aula08.Handler
{
    public class ExemploHandler
    {
        // Tipos de valor anulável - Para permitir valores nulos é usado "?"

        public int? numero = null;
        public bool? boleano= null;

        // Trebalhando com datas - para isso usasse DateTime não é só um tipo de valor
        //Pois ele é uma estrutura de tipo de valor composto de outros tipos de valor, como int.long e double
        //No C# Pode se ir da 00:00:00 01/01/01 até 23:59:99 31/12/9999
        //Possui 11 métodos construtores mas usaremos somente 2

        public DateTime? date01 = new DateTime(2023, 03, 20);

        public DateTime? date02 = new DateTime(2023, 03, 20, 19, 51, 47);
        //Assim como uma classe o DateTime possui atributos
        //Now - é um atributo statico(Não depende de uma variavel)
    }
}
