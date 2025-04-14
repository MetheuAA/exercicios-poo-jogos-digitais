namespace exercicio7.Model
{
    public class MissaoExplorarArea : Missao
    {
        private bool areaExplorada;

        public MissaoExplorarArea(string nomeArea)
            : base("Explorar Área", $"Explore a área: {nomeArea}.")
        {
            areaExplorada = false;
        }

        public void RegistrarExploracao()
        {
            areaExplorada = true;
            VerificarConclusao();
        }

        public override void VerificarConclusao()
        {
            if (!Concluida && areaExplorada)
            {
                ConcluirMissao();
            }
        }
    }
}
    