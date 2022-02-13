namespace DesignPatternDecorator
{
    public class FlavorCake : DecoratorPatternCake
    {
        public FlavorCake(ICake cake) : base(cake)
        {
        }

        public override string CakeDetail()
        {
            string spicytaste = base.CakeDetail();
            spicytaste += "\r\n Spices are added in the cake";
            return spicytaste;
        }
    }
}