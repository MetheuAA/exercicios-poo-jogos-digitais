using System;
using RPGFactoryMethod.Model;

namespace RPGFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Lista de fábricas disponíveis
            ItemFactory[] fabricas = new ItemFactory[]
            {
                new ArmaFactory(),
                new PocaoFactory(),
                new ArmaduraFactory()
            };

            // Escolhe uma fábrica aleatória
            int indice = random.Next(fabricas.Length);
            IItem itemAleatorio = fabricas[indice].CriarItem();

            Console.WriteLine("Item gerado aleatoriamente:");
            itemAleatorio.Usar();
        }
    }
}
