using System;
using DecoratePattern.Beverages;
using DecoratePattern.Condiments;
namespace DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine( beverage.getDescription()+"$"+beverage.getCost());
            beverage = new Mocha(beverage);
            Console.WriteLine( beverage.getDescription()+"$"+beverage.getCost());
        }
    }
}
