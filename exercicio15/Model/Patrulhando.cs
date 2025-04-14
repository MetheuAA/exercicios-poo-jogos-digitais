namespace exercicio15.Model
{
    public class Patrulhando : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo começou a patrulhar a área.");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está patrulhando.");

            if (inimigo.ViuJogador())
            {
                inimigo.MudarEstado(new Perseguindo());
            }
        }
    }
}
