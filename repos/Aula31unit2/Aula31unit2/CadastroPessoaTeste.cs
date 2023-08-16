using Aula31unit2.Application;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aula31unit2.teste
{
    //DISPOSITIVO DE TESTES
    [TestFixture]
    public class CadastroPessoaTeste
    {
        /*private CadastroPessoa cadastro;

        [OneTimeSetUp]
        public void OnTimeInit()
        {
            cadastro = new CadastroPessoa();
        }
        [SetUp]
        public void SetUp()
        {
            // É executado antes de cada um dos testes
        }
        [Test, Order(2)]
        public void DeveDarErroDeCadastro()
        {
            Pessoa pessoa = new Pessoa(1, "Pessoa Teste");
            bool sucesso = cadastro.Cadastrar(pessoa);
            Assert.That(sucesso, Is.False);
        }
        Utilizando Value Execução:
        1 Fernando, 1 Caio
        2 Fernando, 2 Caio
        3 Fernado, 3 Caio
        Com TestCase:
        1, Fernando
        2, Caio
        3, Jéssica
         
        [Order(1)]
        [TestCase (1, "Fernando")]
        [TestCase (2, "Caio")]
        [TestCase (3, "Jéssica")]
        [TestCase (4, "Marcos")]
        [TestCase (5, "João")]
        public void DeveDarSucessoCadastro(int id,string nome)
        {
            Pessoa pessoa = new Pessoa(id, nome);
            bool sucesso = cadastro.Cadastrar(pessoa);
                Assert.That(sucesso, Is.True);
        }

        [Ignore("Ignorado para deixar para depois")]
        [Test, Order(3)]
        public void DeveDarSucessoDeConsulta([Random(1,5,3)]int id)
        {
            Pessoa? pessoa = cadastro.Consultar(1);
            Assert.That(pessoa, Is.Not.Null);
        }
        [TearDown] 
        public void Clear()
        {
            //Executa depois de cada teste
        }
        [OneTimeTearDown]
        public void OneTimeClean()
        {

        }*/

        List<string> frutas = new List<string>
            {
                "Jaca",
                "Goiaba",
                "Melão",
                "Pessego"
            };

        string fruta = "Laranja";

        Pessoa pessoa = new Pessoa(1, "Caio");

        [Test]
        public void ExemploDeTeste()
        {
            //string? texto = "Exepmlo";
            // Assert.That(texto, Is.Not.Null);
            bool booleano = true;
            Assert.That(booleano, Is.True);
        }

        [Test]
        public void ExemploSomeNone()
        {

            // Base para Some e None
            Assert.That(frutas, Has.Some.EqualTo("Jaca"));

            Assert.That(frutas, Has.Exactly(4).Items);
        }

        [Test]
        public void ExemploDeProperty()
        {
            Assert.That(pessoa, Has.Property("Nome"));
        }

        [Test]
        public void ExemploDeNo()
        {
            Assert.That(pessoa, Has.No.Property("CPF"));
        }

        [Test]
        public void ExemploContain()
        {
            Assert.That(frutas, Does.Contain("Jaca"));
        }

        [Test]
        public void ExemploStart()
        {
            //Pode ser usado após a variavel ToLower ou ToUpper para deixar em maiusculo ou minusculo
            //Ex: Assert.That(fruta.ToLower, Does.StartWith("La"));
            Assert.That(fruta, Does.StartWith("La"));
        }

        [Test]
        public void ExemploEnd()
        {
            Assert.That(fruta, Does.EndWith("ja"));
        }

        [Test]
        public void ExemploNot()
        {
            Assert.That(fruta, Does.Not.EndWith("Smt"));
        }

        [Test]
        public void ExemploAnd()
        {
            Assert.That(frutas, Has.Count.GreaterThan(0).And.Contain("Pessego"));
        }
        [Test]
        public void ExemploCount()
        {
            Assert.That(frutas, Has.Count.GreaterThanOrEqualTo(1));
        }
        [Test]
        public void ExemploLenght()
        {
            string CPF = "00000000000";
            Assert.That(CPF, Has.Length.EqualTo(11));
        }

        //Exception*********************************************************************************************
        
        
        [Test]
        public void ExemploException()
        {
            Assert.That(() => ExceptionTeste(), Throws.Exception);
        }
        public void ExceptionTeste()
        {
            throw new Exception();
        }


        [Test]
        public void ExemploArgException()
        {
            Assert.That(() => ArgExceptionTeste(), Throws.ArgumentException);
        }
        public void ArgExceptionTeste()
        {
            throw new ArgumentException();
        }


        [Test]
        public void ExemploArgNullException()
        {
            Assert.That(() => ArgNullExceptionTeste(), Throws.ArgumentNullException);
        }
        public void ArgNullExceptionTeste()
        {
            throw new ArgumentNullException();
        }

        [Test]
        public void ExemploExceptionTypeOf()
        {
            Assert.That(() => TypeOfTeste(), Throws.TypeOf<NullReferenceException>());
        }

        public void TypeOfTeste()
        {
            throw new NullReferenceException();
        }


        [Test]
        public void ExemploNothing() 
        {
            Assert.That(() => NothingTeste(), Throws.Nothing);
        }
        public string NothingTeste()
        {
            return "00000000000";
        }
    }
}
