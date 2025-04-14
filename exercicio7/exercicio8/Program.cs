using System;
using exercicio8.Model;

class Program
{
    static void Main(string[] args)
    {
        var espada = new Espada();
        var armaduraLeve = new ArmaduraLeve();

        var personagem = new Personagem("Arthas", espada, armaduraLeve);
        personagem.ExibirStatus();

        Console.WriteLine("\n--- Equipando novo equipamento ---\n");

        var machado = new Machado();
        var armaduraPesada = new ArmaduraPesada();

        personagem.TrocarArma(machado);
        personagem.TrocarArmadura(armaduraPesada);
        personagem.ExibirStatus();
    }
}
