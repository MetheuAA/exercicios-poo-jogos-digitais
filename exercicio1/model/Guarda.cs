// Model/Guarda.cs
namespace Jogo.Model
{
    public class Guarda : NPC
    {
        public Guarda(string nome, (int x, int y) posicao)
            : base(nome, posicao) { }

        // Implementação do movimento do Guarda
        public override void Mover()
        {
            Console.WriteLine($"{Nome} patrulha a área.");
        }

        // Interagir com o jogador, avisando-o para não passar
        public override void Interagir()
        {
            Console.WriteLine($"{Nome}: Você não pode passar!");
        }
    }
}
