using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Assignment_1
{
    // Program 06
    internal class AreaVolume
    {
        public double Volume(double r)
        {
            double v = (4 / 3) * (22 / 7) * r * r * r;
            return v;
        }
        public double Volume(double h, double r)
        {
            double v = (22 / 7) * r * r * h;
            return v;
        }
        public double Volume(double l, double b, double h)
        {
            double v = l * b * h;
            return v;
        }
        static void Main(string[] args)
        {
            AreaVolume av = new AreaVolume();
            Console.WriteLine(av.Volume(7));
            Console.WriteLine(av.Volume(10, 5));
            Console.WriteLine(av.Volume(10, 12, 20));
        }
    }

    //  Program 09
    class FindArea
    {
        //const double pi = 3.14;
        public void Area(int r)
        {
            int a = r * r;
            Console.WriteLine("Area of Square " + a);
        }
        public void Area(int w, int h)
        {
            int s = w * h;
            Console.WriteLine("Area of Square " + s);
        }
        public void Area(int r, double pi)
        {
            double s = pi * r;
            Console.WriteLine("Area of Square " + s);
        }
        static void Main(string[] args)
        {
            FindArea a = new FindArea();
            a.Area(9);
            a.Area(20, 10);
            a.Area(2,3.14);
        }
    }
}
