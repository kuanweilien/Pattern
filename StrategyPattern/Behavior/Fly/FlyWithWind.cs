using System;
namespace StrategyPattern.Behavior.Fly
{
    public class FlyWithWind:IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I can fly");
        }
    }
}