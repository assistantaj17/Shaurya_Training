using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Delegates
{
    public delegate void mydel(string nm,string msg) ;
    public delegate int mydel2(int n);
    internal class myDelegate1
    {
        static void greet(string nm, string msg)
        {
            Console.WriteLine(nm+"  "+msg);
        }
        
        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }
        static void Main(string[] args)
        {
            mydel d1 = myDelegate1.greet;
            d1("Makar", "Good Evening");
            mydel2 d2 = myDelegate1.factorial;
            int res = d2(10);
            Console.WriteLine(res);
        }
    }
}
