using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_7
    {
        public Section_66_7()
        {
            var values = new[] { 5, 4, 3, 2, 1 };

            var skipTwo = values.Skip(2);
            var takeThree = values.Take(3);
            var skipOneTakeTwo = values.Skip(1).Take(2);
            var takeZero = values.Take(0);
        }
    }
}
