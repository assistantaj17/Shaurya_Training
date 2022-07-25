using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicp.SolidP
{
    internal class Class2
    {
        //The Open-Closed Principle states that
        //“software entities such as modules, classes, functions, etc.should be open for extension,
        //but closed for modification“.

   
    
        public class Invoice
        {
            public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
            {
                double finalAmount = 0;
                if (invoiceType == InvoiceType.FinalInvoice)
                {
                    finalAmount = amount - 100;
                }
                else if (invoiceType == InvoiceType.ProposedInvoice)
                {
                    finalAmount = amount - 50;
                }
                return finalAmount;
            }
        }
        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        };
    
    }

    //if we want to add another new invoice type,
    //then we need to add one more “else if” condition in the same “GetInvoiceDiscount” method,
    //in other words, we need to modify the Invoice class.
    //If we are changing the Invoice class again and again then we need to ensure that
    //the previous functionalities along with the new functionalities are working properly
    //by testing both the functionalities again.

    // OPEN-CLOSED Principle

        
        public class Invoice2
        {
            public virtual double GetInvoiceDiscount(double amount)
            {
                return amount - 10;
            }
        }

        public class FinalInvoice : Invoice2
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 50;
            }
        }
        public class ProposedInvoice : Invoice2
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 40;
            }
        }
        public class RecurringInvoice : Invoice2
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 30;
            }
    }

    

    
        class Program
        {
            static void Main(string[] args)
            {
                Invoice2 FInvoice = new FinalInvoice();
                Invoice2 PInvoice = new ProposedInvoice();
                Invoice2 RInvoice = new RecurringInvoice();

                double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
                double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
                double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

                Console.ReadKey();
            }
        }
    


}
