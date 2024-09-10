using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_54_Recursion_Section_54_1
{
    internal class Section_54_1
    {
        internal Section_54_1()
        {
            Factorial(4);
        }
        public int Factorial(int number)
        {
            return number == 0 ? 1 : number * Factorial(number - 1);
        }

        public int fib(int i)
        {
            if (i <= 2)
            {
                // Base case of the recursive function.
                // i is either 1 or 2, whose associated Fibonacci sequence numbers are 1 and 1.
                return 1;
            }
            // Recursive case. Return the sum of the two previous Fibonacci numbers.
            // This works because the definition of the Fibonacci sequence specifies
            // that the sum of two adjacent elements equals the next element.
            return fib(i - 2) + fib(i - 1);

        }

    }
}
