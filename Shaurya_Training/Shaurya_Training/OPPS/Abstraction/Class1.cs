using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Abstraction
{
    public abstract  class Car
    {
        // common function but different implementation in abstract method
        public abstract double price();
        public abstract int getTotalSeat();
        public abstract string colour();
        // all the common property in normal class
        public string Wheel()
        {
            return "4 Wheeler";
        }
        public string CheckAC()
        {
            return "AC is Available";
        }
        public string CallFacility()
        {
            return "Call Facility Available";
        }
    }
    public class TATA : Car
    {
        public string DiscountPrice() // this is TATA class method
        {
            return "20% Discount on buying TATA cars";
        }
        public override double price()   // these all inherited by base class
        {
            return 1050000.00;             // give all method implementation 
        }
        public override int getTotalSeat()
        {
            return 5;
        }
        public override string colour()
        {
            return "Black";
        }
        static void Main(string[] args)
        {
            TATA t = new TATA();
            Console.WriteLine("-----Common Properties in Car Class--------");
            Console.WriteLine(t.CallFacility());
            Console.WriteLine(t.Wheel());
            Console.WriteLine(t.CheckAC());
            Console.WriteLine("----Own property defined in TATA class-----");
            Console.WriteLine(t.DiscountPrice());
            Console.WriteLine("------Method implementation in TATA class--------");
            Console.WriteLine("Price of car is "+t.price());
            Console.WriteLine(t.getTotalSeat());
            Console.WriteLine(t.colour());
        }
    }

    interface Demo1
    {
        public void Print();
    }
    interface Demo2
    {
        public void Print();
    }
    class Program03 :Demo1,Demo2
    {
        void Demo1.Print()
        {
            Console.WriteLine("Demo1 Interface");
        }
        void Demo2.Print()
        {
            Console.WriteLine("Demo2 Interface");
        }

        static void Main(string[] args)
        {
            Program03 p=new Program03();
            ((Demo1)p).Print();
            ((Demo2)p).Print();
        }
    }

    public abstract class Shape
    {
        public abstract int Area();
    }
    class Square : Shape
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class ABC
    {
        static void Main(string[] args)
        {
            Shape s = new Square(4);
            int result = s.Area();
            Console.WriteLine("Area is "+result);
        }
    }
}
