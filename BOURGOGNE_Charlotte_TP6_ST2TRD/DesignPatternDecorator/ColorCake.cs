namespace DesignPatternDecorator
{
    public class ColorCake : DecoratorPatternCake
    {
        public ColorCake(ICake cake) : base(cake)
        {
        }

        public override string CakeDetail()
        {
            string redcolor = base.CakeDetail();
            redcolor += "\r\n Red color on the cake";
            return redcolor;
        }
    }
}