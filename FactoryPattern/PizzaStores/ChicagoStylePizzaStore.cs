using FactoryPattern.Pizzas;
namespace FactoryPattern.PizzaStores
{
    public class ChicagoStylePizzaStore: PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza;
            switch(type)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                default:
                    pizza = new ClassicPizza();
                    break;
            }

            return pizza;
        }
    }
}