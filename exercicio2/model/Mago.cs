// Model/Mago.cs
namespace Jogo.Model
{
    public class Mago : IAtacante
    {
        public string Nome { get; set; }
        public int AtaqueMagico { get; set; }

        public Mago(string nome, int ataqueMagico)
        {
            Nome = nome;
            AtaqueMagico = ataqueMagico;
        }

        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine($"{Nome} lança uma bola de fogo com {AtaqueMagico} de dano mágico!");
            inimigo.ReceberDano(AtaqueMagico);
        }
    }
}
