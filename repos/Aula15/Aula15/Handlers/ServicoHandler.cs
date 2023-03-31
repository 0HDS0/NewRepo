namespace Aula15.Handlers
{
    public class ServicoHandler
    {
        //Tratamento de execeção Usamos try,catch,finally,throw
        //Todos os tipos de erro tem um bloco chamado de message tipo string
        public string ExecutarServico()
        {
            //Try - É obrigatório

            try
            {
                //Throw - Serve para executar um erro manualmente é utilizado
                //no try para executar um erro personalizado lança um erro para ser capturado pelo catch
                throw new ArgumentNullException("Esse valor não pode ser nulo");
            }

            //catch - é obrigatório e complementar ao try é pra pegar o erro 
            catch (ArgumentNullException EX)
            {
                return EX.Message;
            }

            //finally - é o finalmente ter executado os blocos obrigatório e não é obrigatório
            //sempre será executado 
        }

        public void Teste(int num1,int num2)
        {
            int multi = num1 * num2;
        }
    }
}
