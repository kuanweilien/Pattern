using DecoratePattern.Beverages;
namespace DecoratePattern.Condiments
{
    public abstract class Condiment:Beverage
    {
        public abstract new string getDescription();
        public abstract new double getCost();
    }
}