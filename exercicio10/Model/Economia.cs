using System.Collections.Generic;

namespace exercicio10.Model
{
    public class Economia
    {
        private List<IEconomiaObserver> observadores = new();
        private Dictionary<string, ItemEconomico> itens = new();

        public void RegistrarObserver(IEconomiaObserver observer)
        {
            observadores.Add(observer);
        }

        public void AdicionarItem(ItemEconomico item)
        {
            itens[item.Nome] = item;
        }

        public void RegistrarVenda(string nomeItem)
        {
            if (itens.ContainsKey(nomeItem))
            {
                itens[nomeItem].VendasRecentes++;
            }
        }

        public void AtualizarEconomia()
        {
            foreach (var item in itens.Values)
            {
                decimal precoAntigo = item.PrecoAtual;
                item.AtualizarPreco();

                if (item.PrecoAtual != precoAntigo)
                {
                    NotificarTodos(item.Nome, item.PrecoAtual);
                }
            }
        }

        private void NotificarTodos(string nomeItem, decimal novoPreco)
        {
            foreach (var obs in observadores)
            {
                obs.NotificarAlteracaoPreco(nomeItem, novoPreco);
            }
        }
    }
}
