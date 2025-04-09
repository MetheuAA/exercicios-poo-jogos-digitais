using System;

namespace RPGFactoryMethod.Model
{
    public class Pocao : IItem
    {
        public void Usar()
        {
            Console.WriteLine("Você bebeu uma poção mágica! +50 de vida.");
        }
    }
}
    