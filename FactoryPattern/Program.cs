using FactoryPattern.Stores;
using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nystore = new NYPizzaStore();
            PizzaStore chicagostore = new ChicagoPizzaStore();

            /*NY Pizza Store */
            Console.WriteLine("NY Pizza Store");
            Console.WriteLine("");
            Pizza pizza = nystore.orderPizza("cheese");
            Console.WriteLine("Darla ordered a " + pizza.setName() + "\n");
            pizza = nystore.orderPizza("clam");
            Console.WriteLine("John ordered a " + pizza.setName() + "\n");
            pizza = nystore.orderPizza("veggie");
            Console.WriteLine("Matew ordered a " + pizza.setName() + "\n");
            pizza = nystore.orderPizza("pepperoni");
            Console.WriteLine("Mickey ordered a " + pizza.setName() + "\n");

            /*Chicago Pizza Store */
            Console.WriteLine("Chicago Pizza Store");
            Console.WriteLine("");
            pizza = chicagostore.orderPizza("cheese");
            Console.WriteLine("Mariel ordered a " + pizza.setName() + "\n");
            pizza = chicagostore.orderPizza("clam");
            Console.WriteLine("Johan ordered a " + pizza.setName() + "\n");
            pizza = chicagostore.orderPizza("veggie");
            Console.WriteLine("Eliot ordered a " + pizza.setName() + "\n");
            pizza = chicagostore.orderPizza("pepperoni");
            Console.WriteLine("Darlyn ordered a " + pizza.setName() + "\n");
            Console.ReadKey();
        }
    }
}
