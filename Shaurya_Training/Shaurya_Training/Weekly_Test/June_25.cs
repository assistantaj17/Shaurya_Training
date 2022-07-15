using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shaurya_Training.Weekly_Test
{
    internal class Program01
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            
            var az=new ArrayList();
            for (int i = 0; i < al.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].ToString() == al[j].ToString())
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    az.Add(al[i]);
                }
            }
            foreach (var element in az)
            {
                Console.WriteLine(element);
            }
        }
    }

    
    class Program02
    {
        public class myClass : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                return ((new CaseInsensitiveComparer()).Compare(b, a));
            }
        }
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("Cannot");
            al.Add("Dog");
            al.Add("Fast");
            al.Add("Run");
            al.Add("Zebra");

            Console.WriteLine("Initial value ");
            foreach(var a in al)
                Console.WriteLine(a);

            al.Sort();
            Console.WriteLine("After sorting with default comparer");
            foreach(var a in al)
                Console.WriteLine(a);
            Console.WriteLine("After sorting with custom comparer");
            IComparer myCom = new myClass();
            al.Sort(myCom);
            foreach(Object ob in al)
                Console.WriteLine(ob);

        }
    }

    class Program03
    {
        static void Main(string[] args)
        {

            var word = new List<string> { "THE","SKY","IS","THE","LIMIT" };
            word.Sort((a, b) => a.Length.CompareTo(b.Length));
            Console.WriteLine(string.Join(" ",word));
        }
    }

    class Program04
    {
        int id;
        string name;
        string country;
        string team;

        static void Main(string[] args)
        {

        }
    }

    class Program05
    {
        static void Main(string[] args)
        {
            Hashtable hs=new Hashtable();
            hs.Add("1", "ABC");
            hs.Add("2", "DEF");
            hs.Add("3", "GHI");
            hs.Add("4", "JKL");
            hs.Add("5", "MNO");
            hs.Add("6", "PQR");
            Console.WriteLine("Value at Key 3  "+hs["3"]);

            hs["3"] = "XYZ";
            Console.WriteLine("Value at Key 3(after Updated)  "+hs["3"]);
        }
    }

    class Program06
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("C", "C++");
            ht.Add("D", "Data Structure");
            ht.Add("J", "Java");
            ht.Add("Q", "Quiz");
            ICollection c = ht.Keys;
            Console.WriteLine(ht.ContainsKey("Q"));
            foreach(string str in c)
                Console.WriteLine(str+" ==> "+ht[str]);
            ht["C"] = "C#";
            Console.WriteLine("Updated Value");

            foreach (string str in c)
                Console.WriteLine(str + " ==> " + ht[str]);
        }
    }

    class Program07
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "One");
            hash.Add(2, "Two");
            hash.Add(3, "Three");
            hash.Add(4, "Four");
            hash.Add(5, "Five");
            hash.Add(6, "Six");
            hash.Add(7, "Seven");
            hash.Add(8, "Eight");
            hash.Add(9, "Nine");
            hash.Add(10, "Ten");

            int[] a = new int[hash.Count];
            hash.Keys.CopyTo(a, 0);
            foreach (var d in a)
            {
                if (d % 3 == 0)
                    hash.Remove(d);
            }
            foreach(DictionaryEntry d in hash)
                Console.WriteLine("Key: {0} Value: {1}",d.Key , d.Value);

        }
    }

    class Program08
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Nashik");
            al.Add("Pune");
            ht["list1"] = al;
            ArrayList al1 = (ArrayList)ht["list1"];
            al1.Add("Pune");
            foreach(string z in al)
                Console.WriteLine(z);
            foreach(string x in al1)
                Console.WriteLine(x);
            foreach (string y in al)
            {

            }
                
            

        }
    }
}
