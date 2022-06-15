using System;
namespace FactoryPattern.Pizzas
{
    public class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza(){
            base.name = "Chicago Style Deep Dish Cheese Pizza";
            base.dough = "Extra Thick Crust Dough";
            base.sauce = "Plum Tomto Sauce";
            base.toppings.Add("Shredded Mozzarella Cheese");
        }
        internal new void cut(){
            Console.WriteLine("Cutting the pizza into square slices");
        }

    }
}