namespace exercicio14.Model
{
    public class OpcaoDialogo
    {
        public string Texto { get; private set; }
        public Action ProximaEscolha { get; private set; }

        public OpcaoDialogo(string texto, Action proximaEscolha)
        {
            Texto = texto;
            ProximaEscolha = proximaEscolha;
        }
    }
}
