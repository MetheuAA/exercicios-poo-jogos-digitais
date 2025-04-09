// Program.cs
using System;
using Jogo.Model;

namespace Jogo
{
    class Program
    {
        static void Main()
        {
            // Criando um inimigo com 100 pontos de vida
            Inimigo inimigo = new Inimigo("Goblin", 100);

            // Criando personagens
            IAtacante guerreiro = new Guerreiro("Guerreiro", 30);
            IAtacante mago = new Mago("Mago", 25);
            IAtacante arqueiro = new Arqueiro("Arqueiro", 20);

            // Realizando ataques
            guerreiro.Atacar(inimigo);
            mago.Atacar(inimigo);
            arqueiro.Atacar(inimigo);

            Console.WriteLine($"Vida final do {inimigo.Nome}: {inimigo.Vida}");
        }
    }
}
