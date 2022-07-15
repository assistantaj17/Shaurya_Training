using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Polymorphism
{
    internal class Animal
    {
        public virtual void Bark()  // virtual method in base class
        {
            Console.WriteLine("Animal makes Sound");
        }
    }
    class Doggy : Animal
    {
        public override void Bark()  // override method in derived class
        {
            base.Bark(); // base class method call by base keyword
            Console.WriteLine("Dog says Bow Bow");
        }
        static void Main(string[] args)
        {
            Animal doggy = new Doggy(); // animal reference doggy class
            doggy.Bark();
        }
    }


}
