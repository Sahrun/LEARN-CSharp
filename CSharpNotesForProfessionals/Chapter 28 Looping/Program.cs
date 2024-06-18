using System.Collections;
using System.Globalization;
using System.Security.Authentication;

namespace Chapter_28_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 28: Looping");
            Console.WriteLine();
            Console.WriteLine("Section 28.1: For Loop");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //int input = Int32.Parse(Console.ReadLine());

            //for (; input < 10; input += 2)
            //{
            //    Console.WriteLine(input);
            //}


            Console.WriteLine();
            Console.WriteLine("Section 28.2: Do - While Loop");

            Console.WriteLine("Do While lopp");

            int[] numbers = new int[] { 6, 7, 8, 10 };
            int sum = 0;
            int _i = 0;

            do
            {
                sum += numbers[_i];
                _i++;
            } while (sum <= 10 && _i < numbers.Length);

            Console.WriteLine(sum);


            var list = new List<string>();
            list.Add("Ion");
            list.Add("Andrei");

            foreach (var name in list)
            {
                Console.WriteLine("Hello " + name);
            }

            IEnumerator enumerator;
            IDisposable enumeratorDis;
            enumerator = list.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    string name = (string)enumerator.Current;
                    Console.WriteLine("Hello " + name);
                }
            }
            finally
            {
                enumeratorDis = (IDisposable)enumerator;
                if (enumerator != null)
                    enumeratorDis.Dispose();
            }

            Console.WriteLine();
            Console.WriteLine("Section 28.4: Looping styles");


            Console.WriteLine();
            Console.WriteLine("Section 28.5: Nested loops");

            Console.WriteLine();
            Console.WriteLine("Section 28.6: continue");

            Console.WriteLine();
            Console.WriteLine("Section 28.7: While loop");
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            List<string> cars = new List<string>() { "MOBILIO", "AVANZA", "FORTUNER" };
            IEnumerator<string> largestMetroAreas = cars.GetEnumerator();
            while (largestMetroAreas.MoveNext())
            {
                Console.WriteLine(largestMetroAreas.Current);
            }
        }
    }
}