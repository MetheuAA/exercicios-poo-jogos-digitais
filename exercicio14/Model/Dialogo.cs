namespace exercicio14.Model
{
    public class Dialogo
    {
        public string Texto { get; private set; }
        public List<OpcaoDialogo> Opcoes { get; private set; }

        public Dialogo(string texto)
        {
            Texto = texto;
            Opcoes = new List<OpcaoDialogo>();
        }

        public void AdicionarOpcao(string texto, Action proximaEscolha)
        {
            Opcoes.Add(new OpcaoDialogo(texto, proximaEscolha));
        }

        public void Exibir()
        {
            Console.WriteLine(Texto);
            for (int i = 0; i < Opcoes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Opcoes[i].Texto}");
            }
        }

        public void EscolherOpcao(int indice)
        {
            if (indice >= 0 && indice < Opcoes.Count)
            {
                Opcoes[indice].ProximaEscolha();
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}
