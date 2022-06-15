using System;
using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;
using StrategyPattern.Animal.Duck;
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duck duck = new MallarDuck();
            // duck.display();
            // duck.performFly();
            // duck.performQuack();
            
            Duck model = new ModelDuck();
            model.performFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.performFly();
            
            Console.ReadKey();
        }
    }
}
