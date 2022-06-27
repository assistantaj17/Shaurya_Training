using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Assignment_1
{
    // Program 13
    internal class Excepton
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            for (int i = 0; i <= a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    // Program 14
    class Demo1
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 7, 4, 3 };
            try
            {
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]);
                Console.WriteLine(arr[2]);
                Console.WriteLine(arr[3]);
                Console.WriteLine(arr[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    //  Program 15
    class Multiplecatch
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter any two number");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C=  " + c);
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine(dze.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }
        }
    }

    //  Program 16
    class Example1
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 4, 7, 5, 9, 2, 5 };
                arr[10] = 10 / 5;
                Console.WriteLine("in try block");
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("End of Main");
        }
    }

    
    // Program 18
    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An Exception Occured");
        }
        public void MyDivideExceptiona()
        {
            Console.WriteLine("Divisor should not be zero");
        }
    }
    class TestMyException
    {
        static void Main(string[] args)
        {
            int d, div, res;
            div = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MyDivideExceptiona();
            }
            res = d / div;
            Console.WriteLine("Result " + res);
        }
    }

    //  Program 19
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String Message) : base(Message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("End of main");
        }
    }
}
