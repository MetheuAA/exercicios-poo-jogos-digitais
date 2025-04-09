using System;
using Inventory.Model;

class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario(3);

        Item pocao = new Item("Poção de Vida", TipoEfeito.RecuperarVida, 50);
        Item espada = new Item("Espada Flamejante", TipoEfeito.AumentarDano, 20);
        Item botas = new Item("Botas de Velocidade", TipoEfeito.AumentarVelocidade, 10);

        inventario.AdicionarItem(pocao);
        inventario.AdicionarItem(espada);
        inventario.AdicionarItem(botas);
        inventario.ListarItens();

        inventario.UsarItem("Poção de Vida");
        inventario.ListarItens();

        inventario.RemoverItem("Espada Flamejante");
        inventario.ListarItens();
    }
}
