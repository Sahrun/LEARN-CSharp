using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_18
    {
        public Section_66_18()
        {
            Fibonacci Fibo = new Fibonacci();
            IEnumerable<long> quadrillionplus = Fibo.Where(i => i > 1000000000000);
            Console.WriteLine("Enumerable built");
            Console.WriteLine(quadrillionplus.Take(2).Sum());
            Console.WriteLine(quadrillionplus.Skip(2).First());
            IEnumerable<long> fibMod612 = Fibo.OrderBy(i => i % 612);
            Console.WriteLine("Enumerable built");
            Console.WriteLine(fibMod612.First());//smallest divisible by 612
        }
    }
    public class Fibonacci : IEnumerable<long>
    {
        private int max = 90;
        //Enumerator called typically from foreach
        public IEnumerator GetEnumerator()
        {
            long n0 = 1;
            long n1 = 1;
            Console.WriteLine("Enumerating the Enumerable");
            for (int i = 0; i < max; i++)
            {
                yield return n0 + n1;
                n1 += n0;
                n0 = n1 - n0;


            }
        }


        //Enumerable called typically from linq
        IEnumerator<long> IEnumerable<long>.GetEnumerator()
        {
            long n0 = 1;
            long n1 = 1;
            Console.WriteLine("Enumerating the Enumerable");
            for (int i = 0; i < max; i++)
            {
                yield return n0 + n1;
                n1 += n0;
                n0 = n1 - n0;
            }
        }
    }

   
}