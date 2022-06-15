namespace FactoryPattern.Pizzas
{
    public class ClassicPizza:Pizza
    {
        public ClassicPizza(){
            base.name = "Classic Pizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";
            base.toppings.Add("Grated Reggiano Cheese");
        }
    }
}