namespace Heranca.Model
{
    public class BolaDeFogo : Habilidade
    {
        public BolaDeFogo()
        {
            Nome = "Bola de Fogo";
            CustoDeMana = 20;
            Dano = 50;
        }

        public override void Usar(string nomeDoPersonagem)
        {
            Console.WriteLine($"{nomeDoPersonagem} lançou uma {Nome}, causando {Dano} de dano!");
        }
    }
}
