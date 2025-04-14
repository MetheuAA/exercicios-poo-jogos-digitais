using System;
using System.Collections.Generic;
using exercicio7.Model;

class Program
{
    static void Main(string[] args)
    {
        List<Missao> missoes = new List<Missao>();

        var missao1 = new MissaoDerrotarInimigos(3);
        var missao2 = new MissaoColetarItens(2);
        var missao3 = new MissaoExplorarArea("Floresta Sombria");

        missoes.Add(missao1);
        missoes.Add(missao2);
        missoes.Add(missao3);

        // Simulando progresso
        missao1.RegistrarInimigoDerrotado();
        missao1.RegistrarInimigoDerrotado();
        missao1.RegistrarInimigoDerrotado(); // completa

        missao2.RegistrarItemColetado();
        missao2.RegistrarItemColetado(); // completa

        missao3.RegistrarExploracao(); // completa

        Console.WriteLine("\nResumo das Missões:");
        foreach (var m in missoes)
        {
            Console.WriteLine($"- {m.Nome}: {(m.Concluida ? "Concluída" : "Em andamento")}");
        }
    }
}
