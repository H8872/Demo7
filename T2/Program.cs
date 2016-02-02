using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumber;
            double dNumber;
            bool iresult, dresult;

            Console.WriteLine();

            StreamWriter T2Integers = new StreamWriter(@"D:\H8872\Demo7\T2Integers.txt");
            StreamWriter T2Doubles = new StreamWriter(@"D:\H8872\Demo7\T2Doubles.txt");
            do
            {
                Console.Write(" Give a number(no number or 0 stops asking): ");
                string stuff = Console.ReadLine();
                dresult = double.TryParse(stuff, out dNumber);
                iresult = int.TryParse(stuff, out iNumber);
                if (iresult)
                {
                    T2Integers.WriteLine(stuff);
                }
                else
                {
                    if (dresult)
                    {
                        T2Doubles.WriteLine(stuff);
                    }
                    else
                    {
                        Console.WriteLine(" Stopping..");
                    }
                }
            } while (dresult);
            T2Integers.Close();
            T2Doubles.Close();

            Console.WriteLine(" Stopped\n");

            Console.WriteLine(" Contents of T2Integers.txt:");
            try
            {
                string[] ilines = System.IO.File.ReadAllLines(@"D:\H8872\Demo7\T2Integers.txt");
                foreach (string line in ilines)
                {
                    Console.WriteLine(" -  " + line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(" !! File not found (FileNotFoundException) !!");
            }

            Console.WriteLine("\n Contents of T2Doubles.txt:");
            try
            {
                string[] dlines = System.IO.File.ReadAllLines(@"D:\H8872\Demo7\T2Doubles.txt");
                foreach (string line in dlines)
                {
                    Console.WriteLine(" -  " + line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(" !! File not found (FileNotFoundException) !!");
            }

            Console.WriteLine("\n");
        }
    }
}
