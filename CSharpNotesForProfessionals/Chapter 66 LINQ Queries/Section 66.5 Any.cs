using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_5
    {
        public Section_66_5()
        {
            // Emmty parameter 
            Console.WriteLine("Empty parameter");
            var numbers = new List<int>();
            bool result = numbers.Any(); // false


            numbers = new List<int> { 1, 2, 3, };
            result = numbers.Any();


            // 2. Lambda expression as parameter
            Console.WriteLine("2. Lambda expression as parameter");
            var arrayOfStrings = new string[] { "a", "b", "c" };
            Console.WriteLine(arrayOfStrings.Any(x => x == "a"));
            Console.WriteLine(arrayOfStrings.Any(y => y == "d"));

            // 3. Empty collection
            Console.WriteLine("3. Empty collection");
            numbers = new List<int>();
            result = numbers.Any(I => I >= 0);
            Console.WriteLine(result);

        }
    }
}
