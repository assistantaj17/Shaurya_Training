using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.ThreadDemo
{
    internal class DemoThread
    {
        static void m1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i+Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is "+th.Name);

            Console.WriteLine("Hello World!.......");
            Console.WriteLine("Welcome.......");
            Thread t1 = new Thread(m1); // creating first thread object
            Thread t2 = new Thread(m1); // creating second thread object
            t1.Name = "OM"; // giving name to thread
            t2.Name = "RAM";
            t1.Start(); // start the thread
            t2.Start();
            Console.WriteLine("Main Ends");

        }
    }

    class DemoThread2
    {
        public static void PrintEven()
        {
            Console.WriteLine("Child Thread ");
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine("t1 Thread " + i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread");
            Thread t1 = new Thread(PrintEven);
            t1.Start();
            t1.Join(); // t1 thread join 
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Main " + i);
            }
        }
    }

}
