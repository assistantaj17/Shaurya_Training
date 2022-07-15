using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shaurya_Training.Collection.Non_Generic
{
    internal class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1, "One");  // Adding element with Add() method
            hs.Add(2, "Two");
            hs.Add(3, "Three");
            hs.Add(4, "Four");
            foreach(DictionaryEntry de in hs)  // Print element
                Console.WriteLine("Key: {0}  Value: {1}",de.Key,de.Value);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(10, "Ten");
            dict.Add(11, "Eleven");
            Hashtable ht = new Hashtable(dict); // Adding dictionary eleement to Hashtable

            hs[3] = "THREE"; // Update value in hashtable
            hs[5] = "Five";  // Update value 

            foreach (DictionaryEntry de in hs)
                Console.WriteLine("Key: {0}  Value: {1}", de.Key, de.Value);
            hs.Remove(3); // Remove entry in hashtable
            hs.Remove(4);

            foreach (DictionaryEntry de in hs)
                Console.WriteLine("Key: {0}  Value: {1}", de.Key, de.Value);
        }
    }
}
