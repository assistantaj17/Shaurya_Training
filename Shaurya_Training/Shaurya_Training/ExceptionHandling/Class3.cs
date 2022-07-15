using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.ExceptionHandling
{
    // User defined Exception class
    // Child of Exception
    class DivByZero : Exception
    {

        // Constructor
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }

    class CustomExcep
    {

        // Method to perform Division
        public double DivisionOperation(double numerator,
                                     double denominator)
        {
            // throw exception when denominator
            // value is 0
            if (denominator == 0)
                throw new DivByZero();

            // Otherwise return the result of the division
            return numerator / denominator;
        }
    
        // Main
        static void Main(string[] args)
        {
            CustomExcep obj = new CustomExcep();
            double num = 9, den = 0, quotient;
            try
            {
                // Code block that may cause an exception
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            // Catch block to catch the generic exception
            catch (Exception e)
            {
                // Message property of exception object e
                // will give the specific type of the exception
                Console.Write(e.Message);
            }
        }
    }
}