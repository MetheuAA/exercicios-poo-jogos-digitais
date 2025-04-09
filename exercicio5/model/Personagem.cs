using System;
using System.Collections.Generic;

namespace Heranca.Model
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Mana { get; private set; }
        public List<Habilidade> Habilidades { get; private set; }

        public Personagem(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
            Habilidades = new List<Habilidade>();
        }

        public void AprenderHabilidade(Habilidade habilidade)
        {
            Habilidades.Add(habilidade);
            Console.WriteLine($"{Nome} aprendeu a habilidade {habilidade.Nome}.");
        }

        public void UsarHabilidade(string nomeHabilidade)
        {
            var habilidade = Habilidades.Find(h => h.Nome == nomeHabilidade);
            if (habilidade == null)
            {
                Console.WriteLine($"Habilidade '{nomeHabilidade}' não encontrada.");
                return;
            }

            if (habilidade.CustoDeMana > Mana)
            {
                Console.WriteLine($"{Nome} não tem mana suficiente para usar {nomeHabilidade}.");
                return;
            }

            Mana -= habilidade.CustoDeMana;
            habilidade.Usar(Nome);
            Console.WriteLine($"Mana restante: {Mana}");
        }
    }
}
