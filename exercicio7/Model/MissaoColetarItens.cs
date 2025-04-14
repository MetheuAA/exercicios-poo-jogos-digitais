namespace exercicio7.Model
{
    public class MissaoColetarItens : Missao
    {
        private int itensColetados;
        private int itensNecessarios;

        public MissaoColetarItens(int itensNecessarios)
            : base("Coletar Itens", $"Colete {itensNecessarios} itens.")
        {
            this.itensNecessarios = itensNecessarios;
            this.itensColetados = 0;
        }

        public void RegistrarItemColetado()
        {
            itensColetados++;
            VerificarConclusao();
        }

        public override void VerificarConclusao()
        {
            if (!Concluida && itensColetados >= itensNecessarios)
            {
                ConcluirMissao();
            }
        }
    }
}
