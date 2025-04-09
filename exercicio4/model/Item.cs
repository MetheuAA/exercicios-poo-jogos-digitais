namespace Inventory.Model
{
    public enum TipoEfeito
    {
        RecuperarVida,
        AumentarDano,
        AumentarVelocidade
    }

    public class Item
    {
        public string Nome { get; set; }
        public TipoEfeito Efeito { get; set; }
        public int Valor { get; set; }

        public Item(string nome, TipoEfeito efeito, int valor)
        {
            Nome = nome;
            Efeito = efeito;
            Valor = valor;
        }

        public void Usar()
        {
            Console.WriteLine($"Usando item: {Nome}");

            switch (Efeito)
            {
                case TipoEfeito.RecuperarVida:
                    Console.WriteLine($"=> Recuperou {Valor} de vida.");
                    break;
                case TipoEfeito.AumentarDano:
                    Console.WriteLine($"=> Dano aumentado em {Valor}.");
                    break;
                case TipoEfeito.AumentarVelocidade:
                    Console.WriteLine($"=> Velocidade aumentada em {Valor}.");
                    break;
            }
        }
    }
}
