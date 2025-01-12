using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_46
    {
        public Section_66_46() {
            int[] array = { 1, 2, 3, 4, 2, 5, 3, 1, 2 };
            int n = array.Count(); // returns the number of elements in the array
            int x = array.Count(i => i > 2); // returns the number of elements in the array greater than 2

         //   int[] array1 = GetLargeArray();
           // long n1 = array1.LongCount(); // returns the number of elements in the array
           // long x1 = array1.LongCount(i => i > 100); // returns the number of elements in the array greater than  100

        }
        
    }
}
