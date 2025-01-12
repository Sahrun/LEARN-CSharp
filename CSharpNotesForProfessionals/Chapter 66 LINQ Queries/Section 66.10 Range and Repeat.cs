using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_10
    {
        public Section_66_10()
        {
            // Range
            Console.WriteLine("Range");
            var range = Enumerable.Range(1, 100);

            foreach (var item in range)
                Console.WriteLine(item);


            // Repeat 
            Console.WriteLine("Repeat");
            var repeatedValues = Enumerable.Repeat("a", 3);

            foreach (var item in repeatedValues)
                Console.WriteLine(item);
        }
    }
}
