using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_68_Parallel_LINQ__PLINQ_
{
    internal class Section_68_4
    {
        public Section_68_4()
        {
            var sequence = Enumerable.Range(1, 10000).Select(x => -1 * x); // -1, -2, ...
            var evenNumbers = sequence.AsParallel()
             .OrderBy(x => x)
             .Take(5000)
             .AsUnordered()
            .Where(x => x % 2 == 0) // This line won't be affected by ordering
             .ToList();

        }
    }
}
