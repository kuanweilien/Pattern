using System;
namespace FactoryPattern.Pizzas
{
    public class ChicagoStyleClamPizza:Pizza
    {
        public ChicagoStyleClamPizza(){
            base.name = "Chicago Style Deep Dish Clam Pizza";
            base.dough = "Extra Thick Crust Dough";
            base.sauce = "Plum Tomto Sauce";
            base.toppings.Add("Shredded Mozzarella Cheese");
        }
        internal new void cut(){
            Console.WriteLine("Cutting the pizza into square slices");
        }

    }
}