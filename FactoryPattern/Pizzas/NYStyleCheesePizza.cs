using FactoryPattern.Pizzas;
namespace FactoryPattern
{
    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza(){
            base.name = "NY Style Sauce and Cheese Pizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";
            base.toppings.Add("Grated Reggiano Cheese");
        }
    }
}