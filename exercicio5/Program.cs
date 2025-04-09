using System;
using Heranca.Model;

class Program
{
    static void Main(string[] args)
    {
        Personagem heroi = new Personagem("Arthas", 50);

        heroi.AprenderHabilidade(new BolaDeFogo());
        heroi.AprenderHabilidade(new RaioDeGelo());
        heroi.AprenderHabilidade(new GolpeDeEspada());

        Console.WriteLine();

        heroi.UsarHabilidade("Bola de Fogo");
        heroi.UsarHabilidade("Raio de Gelo");
        heroi.UsarHabilidade("Golpe de Espada");

        Console.WriteLine();
        heroi.UsarHabilidade("Bola de Fogo"); // Vai falhar por falta de mana
    }
}
