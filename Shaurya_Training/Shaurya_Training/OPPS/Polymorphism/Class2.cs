using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Polymorphism
{
    internal class BaseConstructorDemo
    {
        public BaseConstructorDemo()
        {
            Console.WriteLine("Parent class constructor");
        }
    }
    class ChildClass : BaseConstructorDemo
    {
        public ChildClass() : base() 
        {
            Console.WriteLine("Child Class Constructor");
        }
        static void Main(string[] args)
        {
            BaseConstructorDemo demo = new ChildClass();
        }
    }
}
