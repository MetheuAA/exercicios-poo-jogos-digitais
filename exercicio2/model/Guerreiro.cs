// Model/Guerreiro.cs
namespace Jogo.Model
{
    public class Guerreiro : IAtacante
    {
        public string Nome { get; set; }
        public int Ataque { get; set; }

        public Guerreiro(string nome, int ataque)
        {
            Nome = nome;
            Ataque = ataque;
        }

        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine($"{Nome} realiza um ataque corpo a corpo com {Ataque} de dano!");
            inimigo.ReceberDano(Ataque);
        }
    }
}
