namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comentario de uma linha//
            /*
             * Comentario de multiplas linhas
             */
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\nInforme um nome");
            String NamePerson = Console.ReadLine(),
                NameWorker = "Augusto";
            Console.WriteLine("\nO nome");
            Console.WriteLine(NamePerson);
            Console.WriteLine("O Sobrenome");
            Console.WriteLine(NameWorker);

            //Declaração de variaveis

            //String

            Console.WriteLine("\nSeja bem vindo " + NamePerson);

            //Número

            Console.WriteLine("\nInforme um número: ");
            string NumTex = Console.ReadLine();
            int Numero = int.Parse(NumTex);
            int MultX3 = Numero * 3;
            Console.WriteLine("Multiplicação por 3: "+MultX3);


            //Contas  ;-;

            //Adição
            int Soma = Numero + 1;
            float SomaP = Numero + 4.5f;
            decimal SomaDec = Numero + 7.1m;

            Console.WriteLine("\nSoma: " + Soma);
            Console.WriteLine("Soma Float: " + SomaP);
            Console.WriteLine("Soma Decimal: " + SomaDec);

            //Subtração

            int Sub = Numero - 1;
            float SubF = Numero - 4.5f;
            decimal SubDec = Numero - 7.1m;

            Console.WriteLine("\nSubtração: " + Sub);
            Console.WriteLine("Subtração Float: " + SubF);
            Console.WriteLine("Subtração Decimal: " + SubDec);

            //Multiplicação

            int Mult = Numero * 2;
            float MultF = Numero * 4.5f;
            decimal MultDec = Numero * 7.1m;

            Console.WriteLine("\nMultiplicação: " + Mult);
            Console.WriteLine("Multiplicação Float: " + MultF);
            Console.WriteLine("Multiplicação Decimal: " + MultDec);

            //Divisão

            float Div = Numero / 2;
            float DivF = Numero / 4.5f;
            decimal DivDec = Numero / 7.1m;

            Console.WriteLine("\nDivisão: " + Div);
            Console.WriteLine("Divisão Float: " + Div);
            Console.WriteLine("Divisão Decimal: " + Div);

            //Módulo

            float mod = Numero % 3;
            float modQ = Numero % 4;
            float modC = Numero % 5;


            Console.WriteLine("\nMod 3" + mod);
            Console.WriteLine("Mod 4" + modQ);
            Console.WriteLine("Mod 5" + modC);

            //Incremento
            int Inc = 3;
            Console.WriteLine("\nAdicionamento" + Inc++);
            Console.WriteLine("Adicionamento" + ++Inc);

            //Decremento
            int Dec = 3;
            Console.WriteLine("\nSubtraimento" + Dec--);
            Console.WriteLine("Subtraimento" + --Dec);

            //Operações lógicas


            Console.WriteLine("\nNegação");
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            Console.WriteLine("\nAnd");
            Console.WriteLine(true && true);
            Console.WriteLine(false && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);

            Console.WriteLine("\nOr");
            Console.WriteLine(true || true);
            Console.WriteLine(false || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine("\nXOr");
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadKey();
            
        }
        //Valores de constantes não se alteram durante a execução do programa//
        const string NomePet = "Bilu";
        //Com o readonly voce pode definir a constante depois e pode ser alterado apenas uma vez//
        readonly string Email;
        public Program(string email)
        {
            Email = email;
        }


        public void TiposDeDados()
        {
            bool TipoBooleano = true;
            //byte - representa um valor numérico de 8 bits , que ter seu valor entre 0 e 255
            byte TipoByte = 09;
            //sbyte - Valor inteiro de 8 bits, que pode ter seu valor entre -128 a 127
            sbyte TipoSbyte = -74;
            //short - Valor de 16 bits, que pode ter o seu valor entre -32.768 a 32.767
            short TipoShort = -32545;
            //ushort - Valor inteiro de 16 bits, que pode ter o seu valor entre 0 a 65.535
            ushort TipoUshort = 53423;
            //int -  represneta um valor inteiro de 32 bits, que pode ter o seu valor entre -2.147.483.648 a 2.147.483.647
            int TipoInt = -32984372;
            //uint - Representa um valor inteiro de 32 bits, que pode ter seu valor entre 0 a 4.294.967.295
            uint TipoUint = 3746273846;
            //long - Um valor inteiro de 64 bits, que pode ter o seu valor entre -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            long TipoLong = -8648632746286626634;
            //ulong - Um valor númerico inteiro de 64 bits, que pode ter seu valor entre 0 18.446.744.073.709.551.615
            ulong TipoUlong = 12731832719461927634;
            //float - Representa um valor Númerico real de 32 bits, com precisão de até 9 digitos que pode ter valor de aproximadamente 1.2*10^-38 a aproximadamente 3.4*10^+38 deve ter o "f" no fim para float
            float TipoFloat = 8379453753485743573.71361384932324f;
            //double - Representa um valor real de 64 bits, com precisão até 17 dígitos, que pode ter seu valor aproximado de 2.2*10^-308 a 1.7*10^+308 pode ser adicionado o "d" mais não é obrigatório
            double TipoDouble = 12381731723642384723.2348749342302849238472847284792983472873487283478;
            //decimal - Representa um valor númerico de 128 bits, com precisão até de 29 dígitos, que pode ter o seu valor de aproximademente 1.0*10^-28 até aproximadamente 7.9*10^+28 deve ser colocado o "m" no fim
            decimal TipoDecimal = 238238429849282.23478923784m;
            //char - Representa um a cadeia de caracteres, ou seja, um texto de 16bits, definido com aspas simples de no máximo 1 carater
            char TipoChar = 'a';
            /*string - Representa uma cadeia de caracteres, ou seja,um texto, que pode ser definido como um objeto que representa uma coleção sequencial de char
             * O seu tamanho máximo é de 2 GB, mais ou menos 1 bilhão de caracteres em uma string*/
            string TipoString = "Qualquer coisa";
            //object - Tudo dentro do C# é tratado como object pode ser atribuido qualquer valor
            object TipoObject = null;
            //Os que serão usados são bool, int, decimal, double, long, char, float, string.
         }
    }
}