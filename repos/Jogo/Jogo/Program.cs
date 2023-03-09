namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador heroi = new Jogador(123, "Hero", 150, 40, 30);
            NPC goblin = new NPC(123, "Goblin", 200, 50, 15);

            heroi.Defender(goblin.Atacar());

            bool defesaGoblin = goblin.Defender(heroi.Atacar());

            if(!defesaGoblin) { heroi.GanharExperiencia(); }
        }
    }
}