using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    class Student 
    {
        int id;
        string name;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class DemoList
    {
        static void Main(string[] args)
        {
            List<int> primenum = new List<int>();
            primenum.Add(1);
            primenum.Add(3);
            primenum.Add(5);
            primenum.Add(7);

            var city = new List<string>();
            city.Add("Mumbai");
            city.Add("Pune");
            city.Add("Nashik");
            city.Add(null);

            var bigcity = new List<string>()
            {
                "Delhi","Mumbai","Chennai","Kolkata"
            };
            var Student = new List<Student>() {
                new Student(){ID=1,Name="Bill"},
                new Student(){ID=2,Name="Ram"}
            };

            string[] cities = new string[3] { "Pune", "Nagpur", "Kolhapur" };
            var popularcity = new List<string>();
            popularcity.AddRange(cities); // adding element in list

            var favoritecities = new List<string>();
            favoritecities.AddRange(popularcity);

            var result = from s in Student
                         where s.Name == "Bill"
                         select s;
            foreach(var student in result)
                Console.WriteLine(student.ID+" , "+student.Name);

            var number = new List<int>() { 10, 20, 30, 40 };
            number.Insert(1, 11);
            foreach(var num in number)
                Console.WriteLine(num);

            number.Remove(10); // Remove first 10 element from list;
            number.Remove(2);  // Remove the 3 element from list (index start from 0)

            foreach(var n in number)
                Console.WriteLine(n);

            number.Contains(20); // return true
            number.Contains(30); // return true
            number.Contains(22); // return false
        }
    }
}
