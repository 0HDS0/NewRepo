namespace Jogo
{
    public class Personagem
    {
        protected long ID; 
        protected string Nome;
        protected int PontosDeVida;
        protected int Ataque;
        protected int Defesa;
        protected string Direcao = "Norte";

        

        public Personagem(long id, string nome, int pontosDeVida, int ataque, int defesa) 
        { 
            ID= id;
            Nome= nome;
            PontosDeVida= pontosDeVida;
            Ataque= ataque;
            Defesa= defesa;
        }
        public long GetID()
        {
            return ID;
        }
        public string GetNome()
        {
            return Nome;
        }
        public int GetPontosDeVida()
        {
            return PontosDeVida;
        }
        public virtual int Atacar()
        {
            if(PontosDeVida <= 0)
            {
                Console.WriteLine($"O {Nome} está morto e não pode atacar");
                return 0;
            }
            return Ataque;
        }

        public virtual bool Defender(int ataqueDoInimigo)            
        {
            if(PontosDeVida<=0)
            {
                Console.WriteLine($"O {Nome} está morto e não pode defender");
                return false;
            }
            if(Defesa>= ataqueDoInimigo)
            {
                Console.WriteLine("A defesa foi bem sucedida");
                return true;
            }
            else
            {
                Console.WriteLine("A defesa foi bem sucedida!");
                ReceberDano(ataqueDoInimigo - Defesa);
                return false;
            }
        }

        protected void ReceberDano(int dano) 
        {
            PontosDeVida -= dano;
            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O personagem {Nome} morreu");
            }
        }

        public void CurarPontosDeVida(int pontosDeCura) 
        { 
            if (PontosDeVida<= 0)
            {
                Console.WriteLine($"O {Nome} está morto e não pode se curar");
                return;
            }
            PontosDeVida += pontosDeCura;
        }
        public void Andar(int passos) 
        {
            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O {Nome} está morto e não pode andar");
                    return;
            }
            Console.WriteLine($"O {Nome} andou {passos} passos para o {Direcao}");
        }
        public void Andar(int passos, string direcao)
        {
            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O {Nome} morreu e não pode andar");
                    return;
            }
            Console.WriteLine($"O {Nome} virou para o {direcao} e andou {passos}");

        }
    }
}
