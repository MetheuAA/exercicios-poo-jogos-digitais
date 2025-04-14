namespace SeuProjeto.Model
{
    public class GameState
    {
        // Instância única (Singleton)
        private static GameState instance;

        // Propriedades do estado do jogo
        public int NivelAtual { get; private set; }
        public int Pontuacao { get; private set; }
        public int VidasRestantes { get; private set; }

        // Construtor privado
        private GameState()
        {
            NivelAtual = 1;
            Pontuacao = 0;
            VidasRestantes = 3;
        }

        // Método para acessar a instância única
        public static GameState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameState();
                }
                return instance;
            }
        }

        // Métodos para modificar o estado
        public void AvancarNivel() => NivelAtual++;
        public void AdicionarPontuacao(int pontos) => Pontuacao += pontos;
        public void PerderVida()
        {
            if (VidasRestantes > 0) VidasRestantes--;
        }
        public void Reiniciar()
        {
            NivelAtual = 1;
            Pontuacao = 0;
            VidasRestantes = 3;
        }
    }
}
