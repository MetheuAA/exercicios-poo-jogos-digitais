namespace exercicio7.Model
{
    public abstract class Missao
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public bool Concluida { get; protected set; }

        public Missao(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            Concluida = false;
        }

        public abstract void VerificarConclusao();

        protected void ConcluirMissao()
        {
            Concluida = true;
            Console.WriteLine($"Missão \"{Nome}\" concluída!");
        }
    }
}
