using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_45
    {
        public Section_66_45()
        {
            // Create an array.
            int[] array = { 1, 2, 3, 4 };
            // Call reverse extension method on the array 
            Console.WriteLine(array.Reverse());
            var reverse = array.Reverse();
            // Write contents of array to screen.
            Console.WriteLine(array.Reverse());
            foreach (var item in reverse) Console.WriteLine(item);


            //Create List of chars
            List<int> integerlist = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //Reversing the list then taking the two first elements
            IEnumerable<int> reverseFirst = integerlist.Reverse<int>().Take(2);
            Console.WriteLine($"reverseFirst output:{string.Join(",", reverseFirst)}");
            //Taking 2 elements and then reversing only thos two
            IEnumerable<int> reverseLast = integerlist.Take(2).Reverse();
            Console.WriteLine($"reverseLast output: {string.Join(", ", reverseLast)}");
        }
    }
}
