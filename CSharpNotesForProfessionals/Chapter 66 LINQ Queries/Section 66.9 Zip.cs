using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_9
    {
        internal Section_66_9()
        {
            int[] numbers = { 3, 5, 7 };
            string[] words = { "three", "five", "seven", "ignored" };

            IEnumerable<string> zip = numbers.Zip(words, (n, w) => n + "=" + w);
        }
    }
}
