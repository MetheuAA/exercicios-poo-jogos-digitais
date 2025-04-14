namespace exercicio10.Model
{
    public class ItemEconomico
    {
        public string Nome { get; private set; }
        public decimal PrecoBase { get; private set; }
        public decimal PrecoAtual { get; private set; }
        public int VendasRecentes { get; set; }

        public ItemEconomico(string nome, decimal precoBase)
        {
            Nome = nome;
            PrecoBase = precoBase;
            PrecoAtual = precoBase;
            VendasRecentes = 0;
        }

        public void AtualizarPreco()
        {
            if (VendasRecentes > 5)
                PrecoAtual = PrecoBase * 0.8m; // 20% de desconto por muita oferta
            else if (VendasRecentes < 2)
                PrecoAtual = PrecoBase * 1.2m; // 20% de aumento por escassez
            else
                PrecoAtual = PrecoBase;

            VendasRecentes = 0; // reseta para próxima análise
        }
    }
}
