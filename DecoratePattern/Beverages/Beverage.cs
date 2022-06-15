
namespace DecoratePattern.Beverages
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        protected double cost;
        public string getDescription(){
            return description;
        }
        public double getCost(){
            return cost;
        }

    }
}