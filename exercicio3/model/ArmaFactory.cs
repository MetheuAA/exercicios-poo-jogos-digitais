namespace RPGFactoryMethod.Model
{
    public class ArmaFactory : ItemFactory
    {
        public override IItem CriarItem() => new Arma();
    }
}
