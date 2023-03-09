namespace Jogo
{
    public class NPC : Personagem
    {
        public NPC(long id, string nome, int pontosDevida, int ataque, int defesa): base (id, nome, pontosDevida, ataque, defesa)
        {

        }
        public override int Atacar()
        {
            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O {Nome} Foi morto e não pode atacar");
                return 0;
            }

            Random random = new Random();
            double modificador = Convert.ToDouble(random.Next(1, 100)) / 100;
            int ataque = Convert.ToInt32(Math.Truncate(Ataque * modificador));
            return ataque;
        }

        public override bool Defender(int ataqueDoInimigo)
        {

            Random random = new Random();
            double modificador = Convert.ToDouble(random.Next(1, 100)) / 100;
            int defesa = Convert.ToInt32(Math.Truncate(Defesa * modificador));


            if (PontosDeVida <= 0)
            {
                Console.WriteLine($"O {Nome} não consegue defender");
                return true;
            }


            if (defesa >= ataqueDoInimigo)
            {
                Console.WriteLine("A defesa foi bem sucedida");
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
