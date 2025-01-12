using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_68_Parallel_LINQ__PLINQ_
{
    internal class Section_68_2
    {
        public Section_68_2()
        {
            var sequence = Enumerable.Range(1, 10000);
            var eventNumbers = sequence.AsParallel()
                .WithDegreeOfParallelism(4)
                .Where(x => x % 2 == 0).ToList();

            foreach (var sqen in eventNumbers)
            {
                Console.Write(sqen);
            }

        }
    }
}
