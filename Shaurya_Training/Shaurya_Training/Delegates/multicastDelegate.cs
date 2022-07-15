using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Delegates
{
    public delegate void del(int a, int b);
    public delegate int del1(int a, int b);
    internal class multicastDelegate
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("Sum "+(a+b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("Sub "+(a-b));
        }
        public static void prod(int a, int b)
        {
            Console.WriteLine("Prod "+(a*b));
        }

    }
    class MyDelegate
    {
        static void Main(string[] args)
        {
            del d1 = multicastDelegate.add;
            d1 = d1 + multicastDelegate.sub;
            d1+= multicastDelegate.prod;
            d1(10, 5);
        }
    }
    class Program01
    {
        static void Main(string[] args)
        {
            // delegate using annonymous method
            // we can declare method at making object of delegate. write code of method here.
            del d = delegate (int a, int b) { 
                Console.WriteLine("Annonymous Method " + (a + b));
                Console.WriteLine("Annonymous Method " + (a - b));
                Console.WriteLine("Annonymous Method " + (a * b));
                
            };
            d += delegate (int a, int b)
              {
                  Console.WriteLine(a+b);
                  Console.WriteLine(a-b);
              };
            // delegate using lambda function
            // we do not use data type in parameter. just write parameter
            del d2 = (a, b) => Console.WriteLine("Lambda function "+(a+b));
            d(20, 4);
            d2(10, 6);
        }
    }
    class LamdaDemo
    {
        static void Main(string[] args)
        {
            // use of Lambda function with int return type
            // Lambda function using with return keyword
            del1 ob = (a, b) =>
            {
                  return a + b;
            };
            int res=ob(9,5);
            Console.WriteLine(res);
            
            // Lambda function without using return keyword
            // Lambda function understand the return type automatically.
            del1 ob2 = (a, b) => a + b;
            Console.WriteLine("Answer "+ob2(9,2));
        }
    }

    class FunDelegate
    {
        static float add(int a, float b, long m)
        {
            Console.WriteLine("Add "+(a+b+m));
            return (float)(a + b+m); 
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good Afternoon "+nm);
        }

        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func<int,float,long,float> f1 = add;
            float ans = f1(10, 4.5f, 8);
            Console.WriteLine(ans);
            Action<string> f2 = greet;
            f2("Mayank");
            Predicate<int> f3 = isEven;
            Console.WriteLine(f3(47));

        }
    }

    class DemoDelegate
    {
        static void Filter(List<int> lst, Predicate<int> p1)
        {
            foreach (int element in lst)
            {
                bool b = p1(element);
                if(b==true)
                    Console.WriteLine(element);
            }
        }

        static bool isEven(int a)
        {
            return a % 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 27, 48, 39, 47, 92 };
                            
            List<int> l2 = new List<int>();
            foreach (int s in l1)
            {
                if (s % 2 == 0)
                    l2.Add(s);
            }

            List<int> l3 = l1.FindAll((a) => a % 2 == 0);
            foreach (int d in l3)
            {
                Console.WriteLine(d);
            }
        }
    }
}
