using System;

namespace DesignPatternDecorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICake cake = new Cake();
            ICake PersonalizedCake = new FlavorCake(cake);
            Console.WriteLine("\n");
            Console.WriteLine(PersonalizedCake.CakeDetail());

        }
    }
}