using System.Collections.Generic;

namespace BOURGOGNE_Charlotte_TP6_ST2TRD
{
    public enum Meat{
        Ham,
        Beef
    }

    public enum Toppings{
        Tomato,
        Cheese,
        Olive,
        Mushroom
        
    }

    public class Pizza
    {
        public List<Toppings> toppings;
        public Meat meat;

        public Pizza(List<Toppings> toppings, Meat meat){
            this.toppings = toppings;
            this.meat = meat;
        }
    }

    public class PizzaBuilder{
        private List<Toppings> toppings = new List<Toppings>();
        private Meat meat;

        public PizzaBuilder Meat(Meat meat){
            this.meat = meat;   
            return this;
        }

        public PizzaBuilder AddTopping(Toppings topping){
            this.toppings.Add(topping);
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(toppings, meat);
        }

    }
}

