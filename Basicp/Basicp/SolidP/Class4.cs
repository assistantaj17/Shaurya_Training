using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicp.SolidP
{
    // The Interface Segregation Principle states that
    // “Clients should not be forced to implement any methods they don’t use.
    // Rather than one fat interface, numerous little interfaces are preferred based on groups of methods
    // with each interface serving one submodule“.
    internal class Class4
    {  // Interface Segregation Principle

        

    }
    namespace SOLID_PRINCIPLES.ISP
    {
        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
            void Fax(string FaxContent);
            void PrintDuplex(string PrintDuplexContent);
        }
    }

    namespace SOLID_PRINCIPLES.ISP
    {
        public class HPLaserJetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }

            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }

            public void Fax(string FaxContent)
            {
                Console.WriteLine("Fax content");
            }

            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine("Print Duplex content");
            }
        }
    }

    namespace SOLID_PRINCIPLES.ISP
    {
        class LiquidInkjetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }

            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }

            public void Fax(string FaxContent)
            {
                throw new NotImplementedException();
            }

            public void PrintDuplex(string PrintDuplexContent)
            {
                throw new NotImplementedException();
            }
        }
    }

    // in the above LiquidInkjetPrinter class the Fax and PrintDuplex methods are not required by the class but,
    // still, it is implementing these two methods.
    // This is violating the Interface Segregation Principle in C#
    // as we are forcing the class to implement two methods that they don’t require.

    namespace SOLID_PRINCIPLES.ISP
    {
        public interface IPrinterTasks1
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
        }
        interface IFaxTasks
        {
            void Fax(string content);
        }
        interface IPrintDuplexTasks
        {
            void PrintDuplex(string content);
        }
    }

    namespace SOLID_PRINCIPLES.ISP
    {
        public class HPLaserJetPrinter1 : IPrinterTasks1, IFaxTasks,
                                         IPrintDuplexTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }

            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }

            public void Fax(string FaxContent)
            {
                Console.WriteLine("Fax content");
            }

            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine("Print Duplex content");
            }
        }
    }
    namespace SOLID_PRINCIPLES.ISP
    {
        class LiquidInkjetPrinter1 : IPrinterTasks1
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }

            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
        }
    }
}
