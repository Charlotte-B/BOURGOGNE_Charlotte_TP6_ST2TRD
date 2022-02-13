using System;

namespace BOURGOGNE_Charlotte_TP6_ST2TRD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza pizza =
                new PizzaBuilder()
                    .Meat(Meat.Beef)
                    .AddTopping(Toppings.Cheese)
                    .AddTopping(Toppings.Mushroom)
                    .AddTopping(Toppings.Olive)
                    .Build();
            
            Order.OrderPizza(pizza);
        }
    }
}
