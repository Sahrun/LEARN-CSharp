using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_29
{
    internal class Section_52_29
    {
        internal static int AddAll(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        internal static double Add(params double[] numbers)
        {
            Console.WriteLine("Add with array of doubles");
            double total = 0.0;
            foreach (double number in numbers)
            {
                total += number;
            }

            return total;
        }
        internal static int Add(int a, int b)
        {
            Console.WriteLine("Add with 2 ints");
            return a + b;
        }

    }
}
