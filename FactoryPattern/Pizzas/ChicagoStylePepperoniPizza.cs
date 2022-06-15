using System;
namespace FactoryPattern.Pizzas
{
    public class ChicagoStylePepperoniPizza:Pizza
    {
        public ChicagoStylePepperoniPizza(){
            base.name = "Chicago Style Deep Dish Pepperoni Pizza";
            base.dough = "Extra Thick Crust Dough";
            base.sauce = "Plum Tomto Sauce";
            base.toppings.Add("Shredded Mozzarella Cheese");
        }
        internal new void cut(){
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}