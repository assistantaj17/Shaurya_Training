using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shaurya_Training.IO_Function
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            FileStream fr = new FileStream("d://shaurya.txt", FileMode.Append, FileAccess.Write);
            fr.WriteByte(67);
            fr.WriteByte(68);

            FileStream f2 = new FileStream("d://shaurya.txt", FileMode.Append, FileAccess.Read);
            Console.WriteLine(f2.ReadByte);
        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter("d://rein.txt", true);
                sr.WriteLine("Hiii Hello");
                sr.WriteLine("Welcome");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
        }
    }

    class WriteToFile
    {

        public void Data()
        {
            // This will create a file named sample.txt
            // at the specified location 
            StreamWriter sw = new StreamWriter("D://Training.txt");

            // To write on the console screen
            Console.WriteLine("Enter the Text that you want to write on File");

            // To read the input from the user
            string str = Console.ReadLine();

            // To write a line in buffer
            sw.WriteLine(str);

            // To write in output stream
            sw.Flush();

            // To close the stream
            sw.Close();
        }
        // Main Method
        static void Main(string[] args)
        {
            WriteToFile wr = new WriteToFile();
            wr.Data();
            Console.ReadKey();
        }
    }

}
