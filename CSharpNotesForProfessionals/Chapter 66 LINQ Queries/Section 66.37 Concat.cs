using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_37
    {
        public Section_66_37()
        {
            List<int> foo = new List<int>() { 1, 2, 3 };
            List<int> bar = new List<int>() { 3, 4, 5 };

            // through Enumerable static class 
            var result = Enumerable.Concat(foo, bar).ToList();
            result = foo.Concat(bar).ToList();
        }
    }
}
