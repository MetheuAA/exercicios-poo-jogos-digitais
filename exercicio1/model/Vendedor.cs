namespace Jogo.Model
{
    public class Vendedor : NPC
    {
        public Vendedor(string nome, (int x, int y) posicao)
            : base(nome, posicao) { }

        // Implementação do movimento do Vendedor
        public override void Mover()
        {
            Console.WriteLine($"{Nome} se moveu para uma nova posição.");
        }

        // Interagir com o jogador, mostrando itens à venda
        public override void Interagir()
        {
            Console.WriteLine($"{Nome}: Olá, você quer comprar algo?");
        }
    }
}
