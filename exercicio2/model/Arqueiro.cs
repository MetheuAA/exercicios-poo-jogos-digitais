// Model/Arqueiro.cs
namespace Jogo.Model
{
    public class Arqueiro : IAtacante
    {
        public string Nome { get; set; }
        public int DanoArco { get; set; }

        public Arqueiro(string nome, int danoArco)
        {
            Nome = nome;
            DanoArco = danoArco;
        }

        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine($"{Nome} dispara uma flecha com {DanoArco} de dano!");
            inimigo.ReceberDano(DanoArco);
        }
    }
}
