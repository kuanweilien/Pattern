
namespace FactoryPattern.Pizzas
{
    public class NYStylePepperoniPizza:Pizza
    {
        public NYStylePepperoniPizza(){
            base.name = "NY Style Sauce and Pepperoni Pizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";
            base.toppings.Add("Grated Reggiano Cheese");
        }
    }
}