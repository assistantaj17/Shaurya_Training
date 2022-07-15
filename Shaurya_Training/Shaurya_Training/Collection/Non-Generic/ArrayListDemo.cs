using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shaurya_Training.Collection.Non_Generic
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            // Heterogeneous type element,duplicate allowed,null allowed,bool allowed
            ArrayList al = new ArrayList(); 
            al.Add(1);
            al.Add("Raj");  // Adding element with Add() Method
            al.Add(" ");
            al.Add(true);
            al.Add(1);
            al.Add(4.5);
            al.Add(null);
            foreach(var z in al)
                Console.WriteLine(z);

            // Adding element directly
            var al2 = new ArrayList() { 2, "Mithun", 8.6, null, " ", true, 3, 5, 5 };
            int[] arr = { 100, 300, 500, 400 };
            al.AddRange(al2); // adding al2 element in al
            al.AddRange(arr); // adding arr element in al

            foreach (var z in al)
                Console.WriteLine(z);

            Queue mQ = new Queue();
            mQ.Enqueue("Hello");
            mQ.Enqueue("World");

            al.AddRange(mQ); // adding queue element in al
            foreach (var z in al)
                Console.WriteLine(z);

            int firstelement = (int) al[0];
            string secondelement = (string) al[1];
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);
            // using var keyword without explacit casting
            var firste = al[0];
            var seconde = al[1];
            foreach (var z in al)
                Console.WriteLine(z);

            // update element
            al[0] = "Viru";
            al[1] = 5;
            foreach (var z in al)
                Console.WriteLine(z);
            al.Insert(1, "Yuvi");
            foreach (var z in al)
                Console.WriteLine(z);

            al.Remove(null); // Remove first occurance of null
            al.RemoveAt(3); // Remove element at index 3
            al.RemoveRange(0, 2); // Remove 2 element starting from 0 index
            foreach (var z in al)
                Console.WriteLine(z);

            Console.WriteLine(al.Contains(400)); // if present true else false
            Console.WriteLine(al.Contains("Yuvi"));
            Console.WriteLine(al.Contains(null));
        } 
    }
}
