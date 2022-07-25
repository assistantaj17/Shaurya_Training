using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.AppusingLINQ
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }


        public static void Main(string[] args)
        {


            List<Courses> coures = new List<Courses>() {
                new Courses{Id=101,Name="C#",Fees=2000 },
                  new Courses{Id=102,Name="MVC", Fees=4000 },
                  new Courses{Id=103,Name="SQL",Fees=6000 },
                  new Courses{Id=104,Name="Core Java",Fees=8000 },
                  new Courses{Id=105,Name="Ad Java",Fees=10000 },
            };

            //var result1=from c in coures
            //            select c;

            var result2 = from course in coures
                          where course.Fees < 8000
                          orderby course.Name descending
                          select course;

            var result3 = from c in coures
                          where c.Name.StartsWith('C')
                          select c;

            //using LABDA expression
            // =>  arrow operator  also called lambda expression
            var result4 = coures.Where(x => x.Fees < 8000).OrderByDescending(y => y.Name).ToList();

            var result5 = coures.Where(x => x.Id == 101).FirstOrDefault();

            var result6 = coures.Where(y => y.Fees > 5000).OrderBy(y => y.Name).ToList();

            foreach (Courses c in result6)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }
        }
    }
}
