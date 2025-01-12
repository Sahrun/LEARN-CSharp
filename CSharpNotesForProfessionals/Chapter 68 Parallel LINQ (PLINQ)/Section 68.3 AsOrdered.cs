using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_68_Parallel_LINQ__PLINQ_
{
    internal class Section_68_3
    {
        public Section_68_3()
        {
            var sequence = Enumerable.Range(1, 10000);
            var evenNumbers = sequence.AsParallel()
             .AsOrdered()
            .Where(x => x % 2 == 0)
             .ToList();

        }
    }
}
