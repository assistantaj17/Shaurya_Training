using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1); // adding element using Push() Method
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            foreach(int x in st)
                Console.WriteLine(x); // Output always show LIFO manner

            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            Stack<int> s = new Stack<int>(arr);
            foreach(int y in s)
                Console.WriteLine(y); // LIFO manner

            Console.WriteLine("Element in stack: {0} ",s.Count());

            Console.WriteLine( s.Pop()); // remove last enter element 
            Console.WriteLine("Element in Stack:  {0}",s.Count());

            foreach (int y in s)
                Console.WriteLine(y);

            
            Console.WriteLine(st.Peek()); // Peek() display lastly added element but not remove
            Console.WriteLine(st.Peek()); // Peek() gives exception:InvalidOperationException if stack is empty/null 
            
            Console.WriteLine( st.Contains(3)); // if found return true else false
            Console.WriteLine( st.Contains(9)); // output false

           
        }
    }
}
