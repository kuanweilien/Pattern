using System;
namespace StrategyPattern.Behavior.Fly
{
    public class FlyNoWay:IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("i can not fly");
        }

    }
}