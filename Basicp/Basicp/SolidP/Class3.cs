using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicp.SolidP
{
    internal class Class3
    { // Liskov Substitution Principle

        
        class Program
        {
            static void Main(string[] args)
            {
                Apple apple = new Orange();
                Console.WriteLine(apple.GetColor());
            }
        }
        public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    
    }

    // Apple is the base class and Orange is the child class
    // i.e. there is a Parent-Child relationship.
    // So, we can store the child class object in the Parent Reference variable i.e. Apple apple = new Orange();
    // and when we call the GetColor i.e. apple.GetColor(), then we are getting the color of the Orange not the color of Apple.
    // That means once the child object is replaced i.e. Apple storing the Orange object, the behavior is also changed.
    // This is against the LSP Principle.
    // The Liskov Substitution Principle in C# states that even the child object is replaced with the parent,
    // the behavior should not be changed.

    
    
        class Program20
        {
            static void Main(string[] args)
            {
                Fruit fruit = new Orange();
                Console.WriteLine(fruit.GetColor());
                fruit = new Apple();
                Console.WriteLine(fruit.GetColor());
            }
        }
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    
}
