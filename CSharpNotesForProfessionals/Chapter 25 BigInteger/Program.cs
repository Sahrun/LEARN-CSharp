using System.Numerics;

namespace Chapter_25_BigInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 25: BigInteger");
            Console.WriteLine();
            Console.WriteLine("Section 25.1: Calculate the First 1,000-Digit Fibonacci Number");
            BigInteger l1 = 1;
            BigInteger l2 = 1;

            BigInteger current = l1 + l2;

            while (current.ToString().Length < 1000)
            {
                l2 = l1;
                l1 = current;
                current = l1 + l2;
            }
            Console.WriteLine(current);

        }
    }
}