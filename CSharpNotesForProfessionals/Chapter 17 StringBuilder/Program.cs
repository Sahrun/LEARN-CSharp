using System.Diagnostics;
using System.Text;

namespace Chapter_17_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 17: StringBuilder");
            Console.WriteLine();
            Console.WriteLine("Section 17.1: What a StringBuilder is and when to use one");

            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {

                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
            sw.Stop();
            Console.WriteLine("With time : {0}", sw.Elapsed);

            sw.Restart();
            string myString = "";
            for (int i = 0; i < 10000; i++)
            {
                myString += " ";
            }
            Console.WriteLine(myString);
            sw.Stop();
            Console.WriteLine("With time : {0}", sw.Elapsed);

            Console.WriteLine();
            Console.WriteLine("Section 17.2: Use StringBuilder to create string from a large number of records");


        }
    }
}