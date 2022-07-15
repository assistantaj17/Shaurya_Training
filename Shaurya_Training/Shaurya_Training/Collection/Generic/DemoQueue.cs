using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<int> SQ = new Queue<int>();
            SQ.Enqueue(1); // Adding element in queue with Enqueue() Method
            SQ.Enqueue(2);
            SQ.Enqueue(3);
           /* foreach (int k in SQ)
                Console.WriteLine(k);*/
            Queue<string> SQ2 = new Queue<string>();
            SQ2.Enqueue("H");  // Add element and print element in console
            SQ2.Enqueue("E");
            SQ2.Enqueue("L");
            SQ2.Enqueue("L");
            SQ2.Enqueue("O");
            //Console.WriteLine("Total Element : {0}",SQ2.Count); //Count the element present in Queue
            /*foreach (string k in SQ2)
                Console.WriteLine(k);*/

            /* while (SQ2.Count > 0)
                 Console.WriteLine(SQ2.Dequeue()); // Dequeue used to remove element from Queue
             Console.WriteLine("Total Element : {0}", SQ2.Count);*/

            //Console.WriteLine(SQ2.Peek()); //Peek() method always return first element from queue.
            // if queue is empty/null it gives exception : InvalidOperationException

            //Console.WriteLine( SQ2.Contains("L")); // contain() method return true if element is present
            //Console.WriteLine( SQ2.Contains("E")); // else return false
            //Console.WriteLine( SQ2.Contains("Z"));
            


        }
    }
}
