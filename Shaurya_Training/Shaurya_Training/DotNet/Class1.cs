using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.DotNet
{
    /*internal class Course1234
    {
        int id;
        string name;
        int fees;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Fees
        {
            set { fees = value; }
            get { return fees; }
        }
    }
    class Student1234
    {
        int rollno;
        string name;
        string city;
        public int Rollno
        {
            set { rollno = value; }
            get { return rollno;}
        }
        public string Name
        {
            set { name = value; }
            get { return name;}
        }
        public string City
        {
            set { city = value; }
            get { return city;}
        }

        public int CourseId { get; set; }
    }

    public class StudentCource
    {
        public string StudentName { get; set; }
        public string CourceName { get; set; }
    }


    public static class Startup
    {

        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Fees = 10000,
                    Name = "C#"
                },
                new Course
                {
                    Id = 2,
                    Fees = 15000,
                    Name = "MVC"
                },
            };

            List<Student> students = new List<Student>
            {
                new Student { Rollno = 1, Name = "Amol", City = "Pune", CourseId  = 1},
                new Student { Rollno = 2, Name = "Abhijeet", City = "Mummbai", CourseId  = 2},
                new Student { Rollno = 3, Name = "Suraj", City = "Pune", CourseId  = 2},
                new Student { Rollno = 4, Name = "Ajinkya", City = "Pune", CourseId  = 1}
            };

            List<StudentCource> studentCources = new List<StudentCource>();
            var studentsWithCources = students.GroupBy(x => x.CourseId).Select(y => new
            {
                CourceId = y.Key,
                Name = y.FirstOrDefault().Name,

            }).ToList();

            //Console.ReadLine();
        }
    }*/
}
