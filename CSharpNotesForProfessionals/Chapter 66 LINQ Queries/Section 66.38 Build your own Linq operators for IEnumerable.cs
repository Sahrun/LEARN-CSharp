using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_38
    {
        public Section_66_38()
        {
            var items = new List<int> { 2, 3, 4, 5, 6 };

            foreach(List<int> sublist in items.Batch(3))
            {
                Console.WriteLine(sublist);
            }

            var result = Enumerable.Range(0,13)
                                    .Where(x => x%2 == 0)
                                    .ToList();

        }
    }

    public static class LinqExtensions
    {
        public static IEnumerable<List<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
        {
            var batch = new List<T>();
            foreach (T item in source)
            {
                batch.Add(item);
                if (batch.Count == batchSize)
                {
                    yield return batch;
                    batch = new List<T>();
                }
            }

            if (batch.Count > 0)
            {
                yield return batch;
            }
        }
    }
}

