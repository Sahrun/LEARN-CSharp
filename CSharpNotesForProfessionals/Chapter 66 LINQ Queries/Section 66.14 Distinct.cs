using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_14
    {
        internal Section_66_14()
        {
            int[] array = { 1, 2, 3, 4, 2, 5, 3, 1, 2 };
            var distinct = array.Distinct();
            Console.WriteLine("Result Distinct : {0}", string.Join(",", distinct));
        }
    }
}
