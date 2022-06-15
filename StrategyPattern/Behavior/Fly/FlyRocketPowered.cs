using System;
namespace StrategyPattern.Behavior.Fly
{
    public class FlyRocketPowered:IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I am flying with a rocket");
        }
    }
}