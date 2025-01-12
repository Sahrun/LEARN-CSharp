using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_41
    {
        public Section_66_41() {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 2, 3, 4, 5 };
            var allElement = numbers1.Union(numbers2); // AllElement now contains 1,2,3,4,
        }
    }
}
