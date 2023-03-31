using Calculadora.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private OperecaoHandler handler;
        //***********************************************************************
        //Não esqueça de fazer o método contrutor pra poder ser feita a execução
        //***********************************************************************
        public CalculadoraController()
        {
            handler = new OperecaoHandler();
        }

        [HttpGet]
        [Route ("somar/{Num1}/{Num2}")]
        public double GetSoma(double Num1, double Num2)
        {

            return handler.GetSoma(Num1, Num2);
        }

        [HttpGet]
        [Route ("subtracao/{Num1}/{Num2}")]
        public double GetSubtracao(double Num1, double Num2)
        {
            return handler.GetSubtracao(Num1, Num2);
        }
        [HttpGet]
        [Route ("multiplicacao/{Num1}/{Num2}")]
        public double GetMultiplicao(double Num1, double Num2)
        {
            return handler.GetMultiplicacao(Num1, Num2);
        }
        [HttpGet]
        [Route ("multiplicação/{Num1}/{Num2}")]
        public double GetDivisao(double Num1, double Num2)
        {
            return handler.GetDivisao(Num1, Num2);
        }
    }
}
