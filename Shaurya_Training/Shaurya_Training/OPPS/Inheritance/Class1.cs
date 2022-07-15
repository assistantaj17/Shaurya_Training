using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Inheritance
{
    // Single level Inheritance
    internal class Vehicle  // base class
    {
        internal string brand="Ford";
        public void honk()  // base class method
        {
            Console.WriteLine("Tututu........");
        }
    }
    class Car : Vehicle   // derived class 
    {
        public string carname = "Mustang";
    }
    class Prog
    {
        static void Main(string[] args)
        {
            Car c = new Car();  // derived class object
            c.honk();           // derived class object access base class method
            Console.WriteLine(c.brand + "  " + c.carname); // and variable also
        }
    }

    /*class sealed Vehicle
    {
            illegal use of sealed and private keyword in inheritance
    }
    class Car : Vehicle
    {
       it gives error ==>  'Car':cannot derived from sealed type 'Vehicle'
    }*/

    class Animal
    {
        protected void eat()
        {
            Console.WriteLine("Animal eating......");
        }
    }
    class Dog : Animal
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat(); // Protected method access by child class
        }
    }

    class Animal1
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal Eating.......");
        }
    }
    class Dog1 : Animal1
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Dog eating........");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog1 d = new Dog1();
            d.eat();
        }
    }
    // Hybrid Inheritance
    class RegularPolygon    // Base Class
    {
        public void CalPerimeter(int length, int sides)
        {
            int result = length * sides;
            Console.WriteLine("Perimeter is "+result);
        }
    }
    class Square : RegularPolygon  // Derived class  
    {
        public int length = 200;
        public int sides = 4;
        public void CalculateArea()
        {
            int area = length * length;
            Console.WriteLine("Area of Square "+area);
        }
    }
    class Rectangle : RegularPolygon // Derived class
    {
        public int length = 100;
        public int breadth = 200;
        public int sides = 4;
        public void CalculateArea()
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle "+area);
        }
    }
    class Program02
    {
        static void Main(string[] args)
        {
            Square s=new Square();
            s.CalculateArea();
            s.CalPerimeter(s.length, s.sides); // access base class method passing argument

            Rectangle r1 = new Rectangle();
            r1.CalculateArea();
            r1.CalPerimeter(r1.length, r1.breadth); // access base class method passing argument
        }
    }
}
