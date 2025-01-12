using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    public class Section_66_2
    {

        public Section_66_2()
        {

            string[] numbers = { "i", "b", "c", "a", "e", "a", "g" };

            // First()  
            Console.WriteLine("--------------- First() ---------------");
            var result = numbers.First();

            Console.WriteLine(result);

            // With predicate

            Console.WriteLine(numbers.First(x => x.Equals("c")));

            // Exception when not contains

            Console.WriteLine(numbers.First(x => x.Contains("a")));

            // FirstOrDefault()
            Console.WriteLine("--------------- FirstOrDefault() ---------------");

            Console.WriteLine(numbers.FirstOrDefault());
            Console.WriteLine(numbers.FirstOrDefault(x => x.Equals("a")));
            Console.WriteLine(numbers.FirstOrDefault(x => x.Contains("x")) ?? "kosong");

            // Last()
            Console.WriteLine("--------------- Last() ---------------");

            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.Last(x => x.Equals("c")));
            Console.WriteLine(numbers.Last(x => x.Contains("g")));

            // LastOrDefault()
            Console.WriteLine("--------------- LastOrDefault() ---------------");
            Console.WriteLine(numbers.LastOrDefault());
            Console.WriteLine(numbers.LastOrDefault(x => x.Equals("e")));
            Console.WriteLine(numbers.LastOrDefault(x => x.Contains("a")));

            // Single()
            Console.WriteLine("--------------- Single() ---------------");

            Console.WriteLine(numbers.Single(x => x.Equals("b")));
            //Console.WriteLine(numbers.Single());
            Console.WriteLine(numbers.Single(x => x.Equals("c")));
            Console.WriteLine(numbers.Single(x => x.Contains("e")));

            // SingleOrDefault()
            Console.WriteLine("--------------- SingleOrDefault() ---------------");
            Console.WriteLine(numbers.SingleOrDefault(x => x.Equals("y")));
            Console.WriteLine(numbers.SingleOrDefault(x => x == "c"));
            //Console.WriteLine(numbers.SingleOrDefault(x => x == "a"));


            

        }
    }
}