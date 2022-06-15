using StrategyPattern.Behavior.Quack;
using StrategyPattern.Behavior.Fly;
using System;
namespace StrategyPattern.Animal.Duck
{
    public class MallarDuck:Duck
    {
        public MallarDuck(){
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWind();
        }
        public override void display(){
            Console.WriteLine("I am a real Mallar Duck ");

        }
    }
}