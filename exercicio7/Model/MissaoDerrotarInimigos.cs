namespace exercicio7.Model
{
    public class MissaoDerrotarInimigos : Missao
    {
        private int inimigosDerrotados;
        private int inimigosNecessarios;

        public MissaoDerrotarInimigos(int inimigosNecessarios)
            : base("Derrotar Inimigos", $"Derrote {inimigosNecessarios} inimigos.")
        {
            this.inimigosNecessarios = inimigosNecessarios;
            this.inimigosDerrotados = 0;
        }

        public void RegistrarInimigoDerrotado()
        {
            inimigosDerrotados++;
            VerificarConclusao();
        }

        public override void VerificarConclusao()
        {
            if (!Concluida && inimigosDerrotados >= inimigosNecessarios)
            {
                ConcluirMissao();
            }
        }
    }
}
