using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_26
    {
        public Section_66_26()
        {
            int[] list = { 42, 42, 6, 6, 6, 42 };
            var result = list.SkipWhile(i => i == 42);
            // Result: 6, 6, 6, 42
            Console.WriteLine(string.Join(",", result));
        }
    }
}
