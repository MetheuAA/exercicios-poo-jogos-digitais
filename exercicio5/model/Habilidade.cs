namespace Heranca.Model
{
    public abstract class Habilidade
    {
        public string Nome { get; protected set; }
        public int CustoDeMana { get; protected set; }
        public int Dano { get; protected set; }

        public abstract void Usar(string nomeDoPersonagem);
    }
}
