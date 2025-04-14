using System;
using exercicio9.Model;

class Program
{
    static void Main(string[] args)
    {
        var heroi = new Personagem("Luna");

        heroi.ExibirStatus();

        Console.WriteLine("\n--- Derrotando inimigos ---\n");
        heroi.GanharExperiencia(80);
        heroi.ExibirStatus();

        heroi.GanharExperiencia(50); // Vai subir de nível aqui
        heroi.ExibirStatus();

        heroi.GanharExperiencia(200); // Pode subir mais de um nível
        heroi.ExibirStatus();
    }
}
