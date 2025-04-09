namespace Jogo.Model
{
    public abstract class NPC
    {
        // Propriedades comuns a todos os NPCs
        public string Nome { get; set; }
        public (int x, int y) Posicao { get; set; }

        // Construtor para inicializar o nome e a posição
        public NPC(string nome, (int x, int y) posicao)
        {
            Nome = nome;
            Posicao = posicao;
        }

        // Métodos abstratos que serão implementados pelas subclasses
        public abstract void Mover();
        public abstract void Interagir();
    }
}
