namespace exercicio15.Model
{
    public class Perseguindo : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo avistou o jogador e está perseguindo!");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está perseguindo o jogador.");

            if (inimigo.AlcancouJogador())
            {
                inimigo.MudarEstado(new Atacando());
            }
            else if (inimigo.JogadorSeEscondeu())
            {
                inimigo.MudarEstado(new Patrulhando());
            }
        }
    }
}
