using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_54_Recursion_Section_54_6
{
    internal class Factorial
    {
        internal Factorial(long x)
        {

            Console.WriteLine("Result : {0}", Run(x));

        }

        private static long Run(long x)
        {
            if (x < 1)
            {
                throw new IndexOutOfRangeException("Factorial can only be used with positive numbers.");

            }

            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Run(x - 1);
            }
        }
    }
}
