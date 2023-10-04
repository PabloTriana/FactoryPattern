namespace FactoryPattern.Pizzas
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "Ny style Clam Pizza";
            dough = "This Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams from long Island Sound");
        }
    }
}
