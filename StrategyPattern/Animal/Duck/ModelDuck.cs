using StrategyPattern.Behavior.Quack;
using StrategyPattern.Behavior.Fly;
using System;
namespace StrategyPattern.Animal.Duck
{
    public class ModelDuck:Duck
    {
        public ModelDuck(){
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }
        public override void display(){
            Console.WriteLine("I am a Model Duck ");

        }
    }
}