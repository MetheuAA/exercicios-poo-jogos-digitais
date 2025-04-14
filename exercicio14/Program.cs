using System;
using exercicio14.Model;

class Program
{
    static void Main(string[] args)
    {
        var jogador = new Jogador("Luna");
        var npc = new NPC("Guardião da Floresta");

        jogador.InteragirComNPC(npc);

        // Aguardar a resposta do jogador
        Console.Write("\nEscolha uma opção: ");
        int escolha = int.Parse(Console.ReadLine() ?? "0");
        npc.IniciarDialogo();
        // Lidar com a escolha
    }
}
