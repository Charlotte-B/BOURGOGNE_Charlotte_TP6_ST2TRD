namespace DesignPatternDecorator
{
    public class DecoratorPatternCake : ICake
    {
        private ICake _cake;

        public DecoratorPatternCake(ICake cake)
        {
            _cake = cake;
        }

        public virtual string CakeDetail()
        {
            return _cake.CakeDetail();
        }
    }
}