using System;
using System.Collections.Generic;

namespace Inventory.Model
{
    public class Inventario
    {
        private List<Item> itens;
        public int CapacidadeMaxima { get; private set; }

        public Inventario(int capacidadeMaxima)
        {
            CapacidadeMaxima = capacidadeMaxima;
            itens = new List<Item>();
        }

        public bool AdicionarItem(Item item)
        {
            if (itens.Count >= CapacidadeMaxima)
            {
                Console.WriteLine("Inventário cheio! Não foi possível adicionar o item.");
                return false;
            }

            itens.Add(item);
            Console.WriteLine($"Item '{item.Nome}' adicionado ao inventário.");
            return true;
        }

        public bool RemoverItem(string nome)
        {
            Item itemRemover = itens.Find(i => i.Nome == nome);
            if (itemRemover != null)
            {
                itens.Remove(itemRemover);
                Console.WriteLine($"Item '{nome}' removido do inventário.");
                return true;
            }

            Console.WriteLine($"Item '{nome}' não encontrado.");
            return false;
        }

        public void UsarItem(string nome)
        {
            Item itemUsar = itens.Find(i => i.Nome == nome);
            if (itemUsar != null)
            {
                itemUsar.Usar();
                itens.Remove(itemUsar); // Remove após uso
            }
            else
            {
                Console.WriteLine($"Item '{nome}' não encontrado no inventário.");
            }
        }

        public void ListarItens()
        {
            Console.WriteLine("Itens no inventário:");
            foreach (var item in itens)
            {
                Console.WriteLine($"- {item.Nome} ({item.Efeito}, Valor: {item.Valor})");
            }
        }
    }
}
