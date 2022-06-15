using System;
namespace StrategyPattern.Behavior.Quack
{
    public class MuteQuack:IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("<< Silence >>");
        }
    }
}