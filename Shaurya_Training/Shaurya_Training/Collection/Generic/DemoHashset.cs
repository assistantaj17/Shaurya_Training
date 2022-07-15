using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class DemoHashset
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("C");  // Add() used to add element 
            hs.Add("C++");
            hs.Add("C#");
            hs.Add("JAVA");
            hs.Add("Ruby");
            Console.WriteLine("Total Element in Hashset : {0}",hs.Count()); // count of element

            foreach(string s in hs)
                Console.WriteLine(s);

            hs.Remove("Ruby"); // Remove the element 
            //hs.Clear();  // Remove all data in hashset
            foreach (string z in hs)
                Console.WriteLine(z);
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            HashSet<string> hs2 = new HashSet<string>();
            hs2.Add("PHP");
            hs2.Add("Perl");
            hs2.Add("JS");
            hs2.Add("C++");

            /* hs.UnionWith(hs2); // Union of both the hashset
             foreach(string z in hs)
                 Console.WriteLine(z);*/

            /*hs.IntersectWith(hs2); // print element present in both the hashset
            foreach (string z in hs)
                Console.WriteLine(z);*/

            hs.ExceptWith(hs2); // print method present in the single hashset 
            foreach (string z in hs)
                Console.WriteLine(z);
        }

    }
}
