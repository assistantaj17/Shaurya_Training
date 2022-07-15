using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Non_Generic
{
    internal class SortedListDemo
    {
        class Student : IComparable<Student>
        {
            int id;
            string name;
            int percent;
            public int CompareTo(Student s1)
            {
                Console.WriteLine(this + "      " + s1);
                return s1.percent.CompareTo(this.percent);
            }
            public Student(int id, string name, int percent)
            {
                this.id = id;
                this.name = name;
                this.percent = percent;
            }
            public override string ToString()
            {
                return "Id " + id + " Name " + name + " Percent " + percent;
            }
        }

        internal class SortedListDemo1
        {
            static void Main(string[] args)
            {
                SortedList<Student, string> ss = new SortedList<Student, string>();
                ss.Add(new Student(1, "Rahul", 90), "C#");
                ss.Add(new Student(2, "Parag", 80), "Java");
                ss.Add(new Student(3, "Somesh", 70), "C#");
                

                foreach (KeyValuePair<Student, string> kv in ss)
                {
                    Console.WriteLine(kv.Key + "=======" + kv.Value);
                }
            }
        }

        class DemoSB : IComparer<StringBuilder>
        {
            public int Compare(StringBuilder s1, StringBuilder s2)
            {
                return s1.ToString().CompareTo(s2.ToString());
            }
        }

        class DSS4
        {
            static void Main(string[] args)
            {
                SortedList<StringBuilder, int> pp = new SortedList<StringBuilder, int>(new DemoSB());
                pp.Add(new StringBuilder("Ganesh"), 90);
                pp.Add(new StringBuilder("Mahesh"), 70);

                foreach(var s in pp)
                    Console.WriteLine(s.Key+" =====> "+s.Value);
            }
        }
    }
}
