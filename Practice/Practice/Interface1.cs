using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal interface Interface1
    {
        public void Add();
        public void Mul();
    }
    class ABC : Interface1
    {
        int x = 10, y = 20;
        int add;
        double mul;
        public void Add()
        {
            add = x + y;
            Console.WriteLine("Addition is "+add);
        }
        /*public void Data(byte v)
        {
            StreamWriter sw = new StreamWriter("D:\\Shourya_Training");


            v(add);
            sw.WriteLine(add);
            sw.Close();
        }*/
        public void Mul()
        {
            try
            {
                mul = x * y;
                Console.WriteLine("Multiplication is "+mul);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Caught {0}",ex);
            }
        }
        static void Main(string[] args)
        {
            ABC abc = new ABC();
            abc.Add();
            abc.Mul();
        }
    }
}
