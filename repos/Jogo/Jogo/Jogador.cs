using System.Security.Cryptography.X509Certificates;

namespace Jogo
{
    public class Jogador : Personagem
    {
        private int ExpAtual;
        private int Nivel;

        public Jogador(long id, string nome, int pontosDevida, int ataque, int defesa) :
            base(id, nome, pontosDevida, ataque, defesa)
        {

        }
        public int GetNivel()
        {
            return Nivel;
        }
        public void GanharExperiencia()
        {
            ExpAtual += 20;

            if (ExpAtual == 100)
            {
                Nivel++;
                ExpAtual = 0;
                Console.WriteLine("O personagem subiu de Nível !!!");
            }
        }

        public override int Atacar()
        {
            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O NPC {Nome} Foi morto e não pode atacar");
                return 0;
            }

            Random random = new Random();
            double modificador = Convert.ToDouble(random.Next(25, 100)) / 100;
            int ataque = Convert.ToInt32(Math.Truncate(Ataque * modificador));
            return ataque;
        }


        public override bool Defender(int ataqueDoInimigo)
        {

            Random random = new Random();
            double modificador = Convert.ToDouble(random.Next(25, 100)) / 100;
            int defesa = Convert.ToInt32(Math.Truncate(Defesa * modificador));


            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O NPC {Nome} não consegue defender");
                return true;
            }


            if (defesa >= ataqueDoInimigo)
            {
                Console.WriteLine("A defesa foi bem sucedida");
                GanharExperiencia();
                return true;
            }


            else
            {
                Console.WriteLine("A defesa foi bem sucedida!");
                ReceberDano(ataqueDoInimigo - defesa);
                return false;
            }
            

        }
    }
}

