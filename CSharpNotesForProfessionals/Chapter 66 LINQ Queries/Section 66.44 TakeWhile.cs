using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_44
    {
        public Section_66_44()
        {
            int[] list = { 1, 10, 40, 50, 44, 70, 4 };

            var result = list.TakeWhile(x => x < 50).ToList();
            Console.WriteLine(string.Join(",",result));
        }
    }
}
