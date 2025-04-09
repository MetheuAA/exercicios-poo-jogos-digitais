namespace RPGFactoryMethod.Model
{
    public class ArmaduraFactory : ItemFactory
    {
        public override IItem CriarItem() => new Armadura();
    }
}
