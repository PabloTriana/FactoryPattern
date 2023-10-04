using System;

namespace FactoryPattern.Stores
{
    public abstract class PizzaStore
    {
        public abstract Pizza createPizza(string item);

        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            Console.WriteLine("***Making a " + pizza.setName() + "***");
            pizza.preapre();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
