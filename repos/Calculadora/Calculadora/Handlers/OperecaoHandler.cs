

namespace Calculadora.Handlers
{
    public class OperecaoHandler
    {
        //private double handler; 

        public double GetSoma(double Num1, double Num2)
        {
            //handler = 0; 
            //handler = Num1 + Num2;
            return Num1 + Num2;
        }
        public double GetSubtracao(double Num1, double Num2)
        {
            //handler = 0;
            //handler = Num1 - Num2;
            return Num1 - Num2;
        }
        public double GetMultiplicacao(double Num1, double Num2)
        {
            //handler = 0;
           // handler = Num1 * Num2;
            return Num1 * Num2;
        }
        public double GetDivisao(double Num1, double Num2)
        {
            //handler = 0;
            //handler = Num1 / Num2;
            return Num1 / Num2;
        }

    }
}
