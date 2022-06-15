using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza;
            switch(type)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                default:
                    pizza = new ClassicPizza();
                    break;
            }

            return pizza;
        }
    }
}