using FactoryPattern.Pizzas;
namespace FactoryPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type){
            Pizza pizza ;

            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
             
        }
        protected abstract Pizza createPizza(string type);

    }
}