using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Polymorphism
{
    public class Drawing  // base class
    {
        public virtual double Area()  // base class virtual method
        {
            return 0;
        }
    }
    public class Circle : Drawing // derived class
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area() // ovveride method from base class
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }
    public class Square : Drawing
    {
        public double length { set; get; }
        public Square()
        {
            length = 6;
        }
        public override double Area() // override method from base class
        {
            return Math.Pow(length, 2);
        }
    }
    public class Rectangle : Drawing
    {
        public double height { set; get; }
        public double width { set; get; }
        public Rectangle()
        {
            height = 5.3;
            width = 3.4;
        }
        public override double Area()  // override method from base class
        {
            return height * width;
        }
    }
    public class Program03
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine(c.Area());

            Square s = new Square();
            Console.WriteLine(s.Area());

            Rectangle r = new Rectangle();
            Console.WriteLine(r.Area());
        }
    }

    class Animal2
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal MNakes a Sound");
        }
    }
    class Cat : Animal2
    {
        public override void AnimalSound() // override method
        {
            //base.AnimalSound();
            Console.WriteLine("The Cat says:meow meow");
        }
    }
    class Dog : Animal2
    {
        public override void AnimalSound()  // override method
        {
            //base.AnimalSound();
            Console.WriteLine("The Dog says: bow bow");
        }
    }
    class Program04
    {
        static void Main(string[] args)
        {
            // we can create all class object to call all class mehtod or use base keyword in child class
            // method to class base class method.
            // if we do not ride virtual and override keyword it will give only animal class method output.

            Animal2 a = new Animal2();
            a.AnimalSound();

            Cat c = new Cat();
            c.AnimalSound();

            Dog d = new Dog();
            d.AnimalSound();
        }
    }
}
