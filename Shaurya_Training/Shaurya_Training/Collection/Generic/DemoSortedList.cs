using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class DemoSortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> Number = new SortedList<int, string>();
            Number.Add(1, "One");  // Adding element in sortedList with Add() method;
            Number.Add(2, "Two");
            Number.Add(3, "Three");

            foreach (KeyValuePair<int,string> kv in Number)
            {
                Console.WriteLine(kv.Key+" ======> "+kv.Value);
            }
            // This get Exception
            // Number.Add("Five",5);  compile time error: key must be int
            // Number.Add(1,"One");  run time exception: duplicate key
            // Number.Add(null,"Four") run time exception: key cannot be null

            SortedList<string, string> city = new SortedList<string, string>
            {
                {"London","UK" },      // element added without using Add() method
                {"Mumbai","INDIA" },
                {"New York","USA" },
                {"Paris","France" }
            };
            foreach(var k in city)
                Console.WriteLine(k.Key+" ======> "+k.Value);

            SortedList<int, string> Num = new SortedList<int, string>() {
                {1,"One" },
                {3,"Three" },
                {5,"Five" }
            };
            Console.WriteLine("------Initial Key Value Pair--------");
            foreach(KeyValuePair<int,string> kv in Num)
                Console.WriteLine("Key: {0}   Value: {1}",kv.Key,kv.Value);

            Num.Add(2, "Two");
            Num.Add(4, "Four");
            Num.Add(6, "Six");
            Console.WriteLine("-------After Adding---------");
            // SortedList always gives result in sorted form by default ascending
            foreach(var k in Num)
                Console.WriteLine("Key: {0}  Value: {1}",k.Key,k.Value);
            Console.WriteLine(Num[1]);
            Console.WriteLine(Num[3]);
            Console.WriteLine(Num[4]);

            Num[2] = "TWO"; // update value of 2 position key
            Num[8] = "Eight"; // update key if found else add key and value;
            foreach (var k in Num)
                Console.WriteLine("Key: {0}  Value: {1}", k.Key, k.Value);

            Num.Remove(1); // Remove key 1 Pair
            Num.Remove(10); // Remove key 10 Pair not exist it wont gets error
            Num.RemoveAt(0);// Remove key-value pair from index 0
            //Num.RemoveAt(10);// Remove key-value pair from index 10 if not found gives exception
                             // Argument Out Of range Exception
            foreach (var k in Num)
                Console.WriteLine("Key: {0}  Value: {1}", k.Key, k.Value);




        }
    }
}
