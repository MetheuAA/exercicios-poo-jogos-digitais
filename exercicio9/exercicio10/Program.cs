using System;
using exercicio10.Model;

class Program
{
    static void Main(string[] args)
    {
        var economia = new Economia();

        // Itens
        var espada = new ItemEconomico("Espada", 100m);
        var poção = new ItemEconomico("Poção", 50m);

        economia.AdicionarItem(espada);
        economia.AdicionarItem(poção);

        // Comerciante Observador
        var comercianteA = new Comerciante("Léo");
        var comercianteB = new Comerciante("Mina");

        economia.RegistrarObserver(comercianteA);
        economia.RegistrarObserver(comercianteB);

        // Simula vendas
        economia.RegistrarVenda("Espada");
        economia.RegistrarVenda("Espada");
        economia.RegistrarVenda("Espada");
        economia.RegistrarVenda("Espada");
        economia.RegistrarVenda("Espada");
        economia.RegistrarVenda("Espada"); // 6 vendas

        economia.RegistrarVenda("Poção"); // só 1 venda

        // Atualiza a economia e notifica
        Console.WriteLine("\n🔄 Atualizando economia...\n");
        economia.AtualizarEconomia();
    }
}
