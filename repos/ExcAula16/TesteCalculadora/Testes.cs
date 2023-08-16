using NUnit.Framework;
using ExcAula16.Handlers;
using ExcAula16.Domain;
using Microsoft.AspNetCore.Mvc;
using ExcAula16.CommandResult;

namespace TesteCalculadora
{
    [TestFixture]
    public class Testes
    {

        private CalculatorHandler handler;
        Parameters parametro;

        [OneTimeSetUp]
        public void OnTimeInit()
        {
            handler = new CalculatorHandler();
        }

        [TestCase(1, 2, 3)]
        public void TesteAddtionSuccess(double value1, double value2, int result)
        {
            parametro = new Parameters(value1,value2, 1);
            OkObjectResult resultado = (OkObjectResult)handler.Calculation(parametro);
            Assert.That(resultado.Value, Is.EqualTo(result));
        }
        [TestCase(3, 1, 2)]
        public void TesteSubtractionSuccess(double value1, double value2, int result)
        {   
            parametro = new Parameters(value1,value2, 2);
            OkObjectResult resultado = (OkObjectResult)handler.Calculation(parametro);
            Assert.That(resultado.Value, Is.EqualTo(result));
        }
        [TestCase(2, 3, 6)]
        public void TesteMultiplicationSucess(double value1, double value2, int result)
        {
            parametro = new Parameters(value1,value2, 3);
            OkObjectResult resultado = (OkObjectResult)handler.Calculation(parametro);
            Assert.That(resultado.Value, Is.EqualTo(result));
        }
        [TestCase(6, 3, 2)]
        public void TesteDivisionSuccess(double value1,double value2, double result)
        {
            parametro = new Parameters(value1, value2, 4);
            OkObjectResult resultado = (OkObjectResult)handler.Calculation(parametro);
            Assert.That(resultado.Value, Is.EqualTo(result));
        }
        [Test]  
        public void TesteArgumentException()
        {
            parametro = new Parameters(0, 0, 5);
            ObjectResult result = (ObjectResult)handler.Calculation(parametro);
            Assert.That(result.Value/*Usado para pegar o resultado do IActionResult*/
                , Is.EqualTo("Operação não encontrada"));
        }

        [Test]
        public void TesteDivisaoPorZero()
        {
            parametro = new Parameters(1, 0, 4);
            IActionResult result = handler.Calculation(parametro);
            Assert.That(result, Is.TypeOf<DivideByZeroResult>());
        }

        [Test]
        public void TestePropriedade()
        {
            parametro = new Parameters(0,0,0);
            Assert.That(parametro, Has.Property("Value1"));
            Assert.That(parametro, Has.Property("Value2"));
            Assert.That(parametro, Has.Property("Operation"));
        }


    }
}