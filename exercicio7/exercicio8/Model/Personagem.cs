namespace exercicio8.Model
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public IArma Arma { get; private set; }
        public IArmadura Armadura { get; private set; }

        public Personagem(string nome, IArma armaInicial, IArmadura armaduraInicial)
        {
            Nome = nome;
            Arma = armaInicial;
            Armadura = armaduraInicial;
        }

        public void TrocarArma(IArma novaArma)
        {
            Arma = novaArma;
            Console.WriteLine($"{Nome} agora está usando {Arma.Nome}.");
        }

        public void TrocarArmadura(IArmadura novaArmadura)
        {
            Armadura = novaArmadura;
            Console.WriteLine($"{Nome} agora está usando {Armadura.Nome}.");
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Personagem: {Nome}");
            Console.WriteLine($"  Arma: {Arma.Nome} (Dano: {Arma.Dano})");
            Console.WriteLine($"  Armadura: {Armadura.Nome} (Defesa: {Armadura.Defesa})");
            Console.WriteLine($"  Poder Total: {Arma.Dano + Armadura.Defesa}");
        }
    }
}
