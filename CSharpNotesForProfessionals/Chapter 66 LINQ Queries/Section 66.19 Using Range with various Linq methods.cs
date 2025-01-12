using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_19
    {
        public  Section_66_19() {
            var asciiCharacters = Enumerable.Range(0, 256).Select(a => (char)a);

            var evenNumbers = Enumerable.Range(1, 100).Where(a => a % 2 == 0);
        }
    }
}
