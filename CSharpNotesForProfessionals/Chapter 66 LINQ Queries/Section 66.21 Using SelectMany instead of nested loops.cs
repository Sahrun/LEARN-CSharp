using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_21
    {
        public Section_66_21()
        {
            var list1 = new List<string> { "a", "b", "c" };
            var list2 = new List<string> { "1", "2", "3", "4" };

            var result = list1.SelectMany(x => list2.Select(y => $"{x}{y}")).ToList();

            Console.WriteLine($"Result Select Manu : {string.Join(",",result)}");


        }
    }
}
