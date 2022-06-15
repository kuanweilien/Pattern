using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;
using System;
namespace StrategyPattern.Animal.Duck
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        public void performQuack(){
            quackBehavior.quack();
        }
        public void performFly(){
            flyBehavior.fly();
        }
        public abstract void display();
        public void SetFlyBehavior(IFlyBehavior flyBehavior){
            this.flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior){
            this.quackBehavior = quackBehavior;
        }
    }
}