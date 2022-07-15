using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.OPPS.Encapsulation
{
    public class Department
    {
        private string deptname;
        public string Deptname
        {
            set { deptname = value; }
            get { return deptname; }
        }
    }
    class Departmentmain
    {
        static void Main(string[] args)
        {
            Department d = new Department();
            d.Deptname = "Computer Science";
            Console.WriteLine("This is Department of "+d.Deptname);
        }
    }

    class DemoEncap
    {
        private string name;
        private int age;
        public string Name
        {
            set { name = value; }
            get { return name;}
        }
        public int Age
        {
            set { age = value; }
            get { return age;}
        }
    }
    class DemoEnc
    {
        static void Main(string[] args)
        {
            DemoEncap ec = new DemoEncap();
            ec.Name = "Ankita";
            ec.Age = 21;
            Console.WriteLine("Name of Student "+ ec.Name);
            Console.WriteLine("Age of Student "+ ec.Age);
        }
    }
}
