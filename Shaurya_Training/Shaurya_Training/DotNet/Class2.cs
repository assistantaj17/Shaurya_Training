using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.DotNet
{
    internal class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }

        public string City { get; set; }
    }
    class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();
    }
    class Program01
    {
        static void Main(string[] args)
        {
            List<Course> course = new List<Course>()
            {
                new Course{ID=101,Name="C#",Students={new Student { Rollno=1,Name="Rohan"},
                    new Student { Rollno=2,Name="Suraj"},
                    new Student { Rollno=3,Name="Amit"},}},
                new Course{ID=102,Name="MVC",Students=
                {
                    new Student { Rollno=4,Name="Ajinkya"},
                    new Student { Rollno=5,Name="Amol"},
                    new Student { Rollno=6,Name="Neha"},
                } },
                new Course { ID = 103, Name = "SQL", Students =
                    {
                        new Student { Rollno=7,Name="Smita"},
                        new Student { Rollno=8,Name="Gaurav"},
                        new Student { Rollno=9,Name="Manohar"}
                    }
                }

            };
            foreach  (Course c in course)
            {
                Console.WriteLine($"{c.ID} {c.Name}");
                foreach (Student s in c.Students)
                {
                    Console.WriteLine($"\t {s.Name}");
                }
            }
        }

    }
}
