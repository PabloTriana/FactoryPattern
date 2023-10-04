using System;
using System.Collections;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string name, dough, sauce;
        public ArrayList toppings = new ArrayList();

        public void preapre()
        {
            Console.WriteLine("Prepare:" + name);
            Console.WriteLine("Tossing dough: " + dough);
            Console.WriteLine("Adding sauce: " + sauce);
            foreach (String topping in toppings)
            {
                Console.WriteLine("Adding toppings: " + topping);
            }
        }


        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string setName()
        {
            return name;
        }
        public String toString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("*****" + name + "****\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");
            foreach (String topping in toppings)
            {
                display.Append(topping + "\n");
            }
            return display.ToString();
        }
    }
}
