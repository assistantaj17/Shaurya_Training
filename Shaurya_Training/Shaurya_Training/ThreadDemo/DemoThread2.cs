using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shaurya_Training.ThreadDemo
{

    internal class ThreadDemo1
    {

        // Main method
        static void Main(string[] args)
        {

            // Creating and initializing thread
            Thread thr = new Thread(mythread);
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");
        }

        // Static method
        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("mythread ends!!");
        }
    }
    class TDemo2
    {

        // Main method
        static void Main(string[] args)
        {
            // Creating and initializing thread
            Thread thr = new Thread(mythread);

            // Name of the thread is Mythread
            thr.Name = "Mythread";
            thr.Start();

            // IsBackground is the property of Thread
            // which allows thread to run in the background
            thr.IsBackground = true;

            Console.WriteLine("Main Thread Ends!!");
        }
        // Static method
        static void mythread()
        {

            // Display the name of the
            // current working thread
            Console.WriteLine("In progress thread is: {0}",
                                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Completed thread is: {0}",
                              Thread.CurrentThread.Name);
        }
    }
}
