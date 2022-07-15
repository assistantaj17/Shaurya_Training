using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(30);
            ll.AddLast(60);
            ll.AddFirst(50);
            ll.AddLast(40);
            ll.Remove(60);
            LinkedListNode<int> addr = ll.Find(30);
            ll.AddAfter(addr, 500);

            foreach (int s in ll)
                Console.WriteLine(s);
        }
    }
}
