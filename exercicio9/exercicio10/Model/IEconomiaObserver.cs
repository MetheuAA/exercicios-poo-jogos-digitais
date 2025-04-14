namespace exercicio10.Model
{
    public interface IEconomiaObserver
    {
        void NotificarAlteracaoPreco(string nomeItem, decimal novoPreco);
    }
}
