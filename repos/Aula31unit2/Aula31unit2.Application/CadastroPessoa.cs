using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula31unit2.Application
{
    public class CadastroPessoa
    {
        private List<Pessoa> pessoas;

        public CadastroPessoa() 
        {
            pessoas= new List<Pessoa>();
        }
        public bool Cadastrar(Pessoa pessoa)
        {
            Pessoa? pessoaExistente = 
                pessoas.Where(x => x.ID == pessoa.ID)
                    .FirstOrDefault();

            if (pessoaExistente != null)
                return false;

            pessoas.Add(pessoa);
            return true;
        }
        public Pessoa? Consultar(int id)
        {
            return pessoas.Where(p => p.ID == id).FirstOrDefault();
        }
    }
}
