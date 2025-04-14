namespace exercicio9.Model
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nivel { get; private set; }
        public int Experiencia { get; private set; }
        public int ExperienciaParaProximoNivel { get; private set; }

        public int Forca { get; private set; }
        public int Agilidade { get; private set; }
        public int VidaMaxima { get; private set; }
        public int VidaAtual { get; private set; }

        public Personagem(string nome)
        {
            Nome = nome;
            Nivel = 1;
            Experiencia = 0;
            ExperienciaParaProximoNivel = 100;

            Forca = 10;
            Agilidade = 10;
            VidaMaxima = 100;
            VidaAtual = VidaMaxima;
        }

        public void GanharExperiencia(int quantidade)
        {
            Console.WriteLine($"{Nome} ganhou {quantidade} de experiência!");
            Experiencia += quantidade;

            while (Experiencia >= ExperienciaParaProximoNivel)
            {
                SubirNivel();
            }
        }

        private void SubirNivel()
        {
            Experiencia -= ExperienciaParaProximoNivel;
            Nivel++;
            ExperienciaParaProximoNivel = (int)(ExperienciaParaProximoNivel * 1.5);

            Forca += 5;
            Agilidade += 3;
            VidaMaxima += 20;
            VidaAtual = VidaMaxima;

            Console.WriteLine($"\n🎉 {Nome} subiu para o nível {Nivel}!");
            Console.WriteLine($"Novo status -> Força: {Forca}, Agilidade: {Agilidade}, Vida Máxima: {VidaMaxima}\n");
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Personagem: {Nome}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Experiência: {Experiencia}/{ExperienciaParaProximoNivel}");
            Console.WriteLine($"Força: {Forca} | Agilidade: {Agilidade} | Vida: {VidaAtual}/{VidaMaxima}");
        }
    }
}
