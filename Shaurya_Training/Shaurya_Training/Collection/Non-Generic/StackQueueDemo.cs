using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shaurya_Training.Collection.Non_Generic
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push(1);     // Adding element with the help of Push() Method
            mystack.Push("Two");
            mystack.Push(true);
            mystack.Push(5.9);
            mystack.Push(null);
            foreach(var z in mystack)
                Console.WriteLine(z);

            int[] arr = new int[] { 9, 8, 7, 6, 5 };
            Stack s = new Stack(arr);  // Adding array element in stack
            foreach (var z in s)
                Console.WriteLine(z);

            Console.WriteLine("Number of element in stack ",mystack.Count); // give count of element present in stack

            Console.WriteLine(mystack.Pop()); // return lastly added value and remove it from stack

            Console.WriteLine(mystack.Peek()); // return lastly added value but not remove it

            Console.WriteLine(mystack.Contains(3)); // it show element present in stack or not (true/false)

            foreach (var z in mystack)
                Console.WriteLine(z);
            
        }
    }

    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q=new Queue();
            q.Enqueue("Harsh");  // adding element by Enqueue() method
            q.Enqueue('a');
            q.Enqueue(false);
            q.Enqueue(70);

            foreach (var z in q)
                Console.WriteLine(z);

            Console.WriteLine(q.Dequeue()); // Dequeue() remove and return first element 

            Console.WriteLine(q.Peek()); // Peek() return the first element

            Console.WriteLine(q.Contains('a')); // element present or not

            foreach (var z in q)
                Console.WriteLine(z);

            
        }
        
    }
}
