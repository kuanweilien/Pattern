using System;
using FactoryPattern.Pizzas;
using  FactoryPattern.PizzaStores;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a "+pizza.GetName());
            Console.WriteLine("");
            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a "+pizza.GetName());
        }
    }
}
