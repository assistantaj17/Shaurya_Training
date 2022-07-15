using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Polymorphism
{
    public class PrintData
    {
        void Print(int i)  // method with integer data type
        {
            Console.WriteLine("int type argument " + i);
        }
        void Print(double f) // overload method with double data type
        {
            Console.WriteLine("Double type argument " + f);
        }
        void Print(string s) // overload method with string data type
        {
            Console.WriteLine("String type argument " + s);
        }
        static void Main(string[] args)
        {
            PrintData printData = new PrintData(); 
            printData.Print(9854); // call int argument type method
            printData.Print(500.8); // call double argument type method
            printData.Print("Method Overloading"); // call string argument type method
        }
    }

    // Constructor Overloading

    class Car
    {
        public Car()  // First Constructor
        {
            Console.WriteLine("Default Constructor");
        }
        public Car(int a) // Second Constructor 
        {
            Console.WriteLine("Parameterized Constructor with 1 arguments");
        }
        public Car(int a, float b) // third Constructor
        {
            Console.WriteLine("Parameterized Constructor with 2 arguments");
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            Car c1 = new Car(10);
            Car c2 = new Car(20, 30.5f);
        }
    }

}
