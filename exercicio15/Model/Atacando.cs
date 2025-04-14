namespace exercicio15.Model
{
    public class Atacando : EstadoInimigo
    {
        public void EntrarNoEstado(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está atacando o jogador!");
        }

        public void Atualizar(Inimigo inimigo)
        {
            Console.WriteLine("Inimigo está atacando.");

            // Aqui podemos adicionar lógica de ataque
            if (inimigo.JogadorSeEscondeu())
            {
                inimigo.MudarEstado(new Patrulhando());
            }
        }
    }
}
