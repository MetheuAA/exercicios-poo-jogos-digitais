using System;
using SeuProjeto.Model;

class Program
{
    static void Main(string[] args)
    {
        // Acessando o estado do jogo
        GameState estado = GameState.Instance;

        estado.AdicionarPontuacao(100);
        estado.AvancarNivel();
        estado.PerderVida();

        Console.WriteLine("Nível: " + estado.NivelAtual);
        Console.WriteLine("Pontuação: " + estado.Pontuacao);
        Console.WriteLine("Vidas: " + estado.VidasRestantes);

        // Acessando a mesma instância de outro ponto
        GameState outroEstado = GameState.Instance;
        outroEstado.PerderVida();

        Console.WriteLine("Vidas após outra perda: " + estado.VidasRestantes);
    }
}
