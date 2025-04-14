namespace exercicio10.Model
{
    public class Comerciante : IEconomiaObserver
    {
        public string Nome { get; private set; }

        public Comerciante(string nome)
        {
            Nome = nome;
        }

        public void NotificarAlteracaoPreco(string nomeItem, decimal novoPreco)
        {
            Console.WriteLine($"[Comerciante {Nome}] Novo preço para {nomeItem}: {novoPreco:C}");
        }
    }
}
