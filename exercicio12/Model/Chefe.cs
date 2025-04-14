namespace exercicio12.Model
{
    public class Chefe
    {
        private GerenciadorEventos eventos;

        public Chefe(GerenciadorEventos eventos)
        {
            this.eventos = eventos;
            eventos.ChefeDerrotado += LiberarNovaArea;
        }

        public void Derrotar()
        {
            eventos.DispararChefeDerrotado();
        }

        private void LiberarNovaArea()
        {
            Console.WriteLine("[Chefe] Nova área foi desbloqueada no mapa!");
        }
    }
}
