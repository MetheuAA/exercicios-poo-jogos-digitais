namespace RPGFactoryMethod.Model
{
    public class PocaoFactory : ItemFactory
    {
        public override IItem CriarItem() => new Pocao();
    }
}
