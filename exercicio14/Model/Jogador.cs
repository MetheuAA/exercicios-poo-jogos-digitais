namespace exercicio14.Model
{
    public class Jogador
    {
        public string Nome { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void InteragirComNPC(NPC npc)
        {
            Console.WriteLine($"\n{Nome} interage com {npc.Nome}...");
            npc.IniciarDialogo();
        }
    }
}
