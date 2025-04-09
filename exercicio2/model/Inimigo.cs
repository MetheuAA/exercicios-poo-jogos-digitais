// Model/Inimigo.cs
namespace Jogo.Model
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int Vida { get; set; }

        public Inimigo(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
            Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida restante: {Vida}");
        }
    }
}
