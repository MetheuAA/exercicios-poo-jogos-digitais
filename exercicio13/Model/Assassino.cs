namespace exercicio13.Model
{
    public class Assassino : CartaBase
    {
        public Assassino(string nome) : base(nome, 25, 7) {}

        public override void UsarHabilidade(CartaBase alvo)
        {
            Console.WriteLine($"{Nome} realiza Ataque Crítico em {alvo.Nome}!");
            alvo.ReceberDano(Ataque + 10);
        }
    }
}
    