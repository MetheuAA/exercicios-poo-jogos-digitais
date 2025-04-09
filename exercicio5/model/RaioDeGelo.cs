namespace Heranca.Model
{
    public class RaioDeGelo : Habilidade
    {
        public RaioDeGelo()
        {
            Nome = "Raio de Gelo";
            CustoDeMana = 15;
            Dano = 35;
        }

        public override void Usar(string nomeDoPersonagem)
        {
            Console.WriteLine($"{nomeDoPersonagem} lançou um {Nome}, causando {Dano} de dano e congelando o inimigo!");
        }
    }
}
