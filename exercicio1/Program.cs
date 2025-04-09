// Program.cs
using System;
using Jogo.Model;

namespace Jogo
{
    class Program
    {
        static void Main()
        {
            // Criando uma posição para o jogador
            var jogadorPosicao = (x: 5, y: 5);

            // Criando NPCs
            NPC vendedor = new Vendedor("João", (x: 3, y: 3));
            NPC guarda = new Guarda("Guarda1", (x: 2, y: 2));
            NPC vilao = new Vilao("Vilão", (x: 0, y: 0), jogadorPosicao);

            // Movendo e interagindo com NPCs
            vendedor.Mover();
            vendedor.Interagir();

            guarda.Mover();
            guarda.Interagir();

            vilao.Mover();
            vilao.Interagir();
        }
    }
}
