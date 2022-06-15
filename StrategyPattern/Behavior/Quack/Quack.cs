using System;
namespace StrategyPattern.Behavior.Quack
{
    public class Quack:IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("quack quack quack~");
        }
    }
}