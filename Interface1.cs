using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Assignment_1
{
    // Program 04
    interface Cake
    {
        void Bake();
    }
    class Strawberry : Cake
    {
        public void Bake()
        {
            Console.WriteLine("Strawberry Cake");
        }
        static void Main(string[] args)
        {
            Cake cs = new Strawberry();
            cs.Bake();
        }
    }
    class BlackForest : Cake
    {
        public void Bake()
        {
            Console.WriteLine("BlackForest Cake");
        }
        static void Main(string[] args)
        {
            Cake cb = new BlackForest();
            cb.Bake();
        }
    }
    //  Program 05

    interface IceCream
    {
        void eat();
    }
    interface Juice
    {
        void drink();
    }
    class Mastani : IceCream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Are you come to eat Mastani");
        }
        public void drink()
        {
            Console.WriteLine("Are you come to drink juice");
        }
    }
}
