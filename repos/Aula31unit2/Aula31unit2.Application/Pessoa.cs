using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula31unit2.Application
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Pessoa(int id, string nome) 
        { 
            ID= id;
            Nome= nome;
        }
    }
}
