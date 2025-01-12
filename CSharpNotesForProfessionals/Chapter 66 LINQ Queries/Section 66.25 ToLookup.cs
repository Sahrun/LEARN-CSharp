using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_25
    {
        public Section_66_25()
        {
            string[] array = { "one", "two", "three" };

            var lookup = array.ToLookup(item => item.Length);

            Console.WriteLine(string.Join(", ", lookup[3]));

            int[] array_int = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var lookup1 = array_int.ToLookup(item => item % 2);

            Console.WriteLine(string.Join(",", lookup1[0]));

            Console.WriteLine(string.Join(",", lookup1[1]));
        }
    }
}
