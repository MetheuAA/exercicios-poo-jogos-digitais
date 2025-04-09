namespace Heranca.Model
{
    public class GolpeDeEspada : Habilidade
    {
        public GolpeDeEspada()
        {
            Nome = "Golpe de Espada";
            CustoDeMana = 0;
            Dano = 25;
        }

        public override void Usar(string nomeDoPersonagem)
        {
            Console.WriteLine($"{nomeDoPersonagem} executou um {Nome}, causando {Dano} de dano físico!");
        }
    }
}
