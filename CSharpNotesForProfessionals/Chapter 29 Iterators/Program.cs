using System.Collections;

namespace Chapter_29_Iterators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 29: Iterators");

            Console.WriteLine("Section 29.1: Creating Iterators Using Yield");

            foreach (int term in Fibonacci(10))
            {
                Console.WriteLine(term);
            }


            Console.WriteLine();
            Console.WriteLine("Section 29.2: Simple Numeric Iterator Example");

            int[] numbers = { 1, 2, 3, 4, 5 };

            IEnumerator interior = numbers.GetEnumerator();

            while (interior.MoveNext())
            {
                Console.WriteLine(interior.Current);
            }

        }



        static IEnumerable<int> Fibonacci(int count)
        {
            int prev = 1;
            int curr = 1;

            for (int i = 0; i < count; i++)
            {
                yield return prev;
                int temp = prev + curr;
                prev = curr;
                curr = temp;
            }

        }
    }
}