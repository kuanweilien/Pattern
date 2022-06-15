using System;
using System.Collections.Generic;
namespace FactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        internal void prepare(){
            Console.WriteLine("Preparing "+name);
            Console.WriteLine("Tossing dough ...");
            Console.WriteLine("Adding sauce ...");
            Console.WriteLine("Adding toppings: ");
            foreach(string topping in toppings){
                Console.WriteLine("   " + topping);
            }
        }
        internal void bake(){
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        internal void cut(){
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        internal void box(){
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string GetName(){
            return name;
        }




    }
}