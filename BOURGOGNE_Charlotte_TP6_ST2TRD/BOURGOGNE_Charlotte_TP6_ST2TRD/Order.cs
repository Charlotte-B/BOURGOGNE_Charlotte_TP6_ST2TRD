using System;

namespace BOURGOGNE_Charlotte_TP6_ST2TRD
{
    public class Order
    {
        public static void OrderPizza(Pizza pizza)
        {
            Console.WriteLine("Pizza with:");
            Console.WriteLine("Meat: "+ pizza.meat);
            
            Console.Write("Toppings: ");
            foreach (var topping in pizza.toppings)
            {
                Console.Write(topping + " ");
            }

        }
    }
}