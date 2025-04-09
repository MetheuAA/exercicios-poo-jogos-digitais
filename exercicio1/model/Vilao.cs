// Model/Vilao.cs
namespace Jogo.Model
{
    public class Vilao : NPC
    {
        private (int x, int y) jogadorPosicao;

        public Vilao(string nome, (int x, int y) posicao, (int x, int y) jogadorPosicao)
            : base(nome, posicao)
        {
            this.jogadorPosicao = jogadorPosicao;
        }

        // Implementação do movimento do Vilão (perseguir o jogador)
        public override void Mover()
        {
            if (Posicao.x < jogadorPosicao.x)
                Posicao = (Posicao.x + 1, Posicao.y);
            else if (Posicao.x > jogadorPosicao.x)
                Posicao = (Posicao.x - 1, Posicao.y);

            if (Posicao.y < jogadorPosicao.y)
                Posicao = (Posicao.x, Posicao.y + 1);
            else if (Posicao.y > jogadorPosicao.y)
                Posicao = (Posicao.x, Posicao.y - 1);

            Console.WriteLine($"{Nome} se moveu para {Posicao.x}, {Posicao.y} e está perseguindo o jogador!");
        }

        // Interagir com o jogador (atacar o jogador quando perto)
        public override void Interagir()
        {
            if (Math.Abs(Posicao.x - jogadorPosicao.x) <= 1 && Math.Abs(Posicao.y - jogadorPosicao.y) <= 1)
            {
                Console.WriteLine($"{Nome}: Eu te atacarei agora!");
            }
            else
            {
                Console.WriteLine($"{Nome}: Eu estou perto, mas não o atacarei ainda.");
            }
        }
    }
}
