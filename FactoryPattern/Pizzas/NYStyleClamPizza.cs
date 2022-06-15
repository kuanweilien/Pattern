
namespace FactoryPattern.Pizzas
{
    public class NYStyleClamPizza:Pizza
    {
        public NYStyleClamPizza(){
            base.name = "NY Style Sauce and Clam Pizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";
            base.toppings.Add("Grated Reggiano Cheese");
           }
    }
}