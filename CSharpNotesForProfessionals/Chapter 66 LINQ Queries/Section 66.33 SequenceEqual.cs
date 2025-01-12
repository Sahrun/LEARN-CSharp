using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_33
    {
        public Section_66_33()
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3 };
            int[] c = new int[] { 1, 3, 2 };
            bool returnsTrue = a.SequenceEqual(b);
            bool returnsFalse = a.SequenceEqual(c);
        }
    }
}
