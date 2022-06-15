using DecoratePattern.Beverages;
namespace DecoratePattern.Condiments
{
    public class Mocha : Condiment
    {
        Beverage beverage;
        public Mocha(Beverage beverage){
            this.beverage = beverage;
        }

        public override double getCost()
        {
            return beverage.getCost()+0.2;
        }

        public override string getDescription()
        {
            return beverage.getDescription()+" ,Mocha";
        }
    }
}