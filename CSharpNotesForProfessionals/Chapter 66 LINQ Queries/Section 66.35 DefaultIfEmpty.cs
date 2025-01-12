using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_35
    {
        public Section_66_35()
        {
            var chars = new List<string>() { "a", "b", "c", "d" };
            var first = chars.DefaultIfEmpty("N/A").FirstOrDefault();
            Console.WriteLine("result 1 : {0}", first);
            first = chars.Where(chars => chars.Length > 1)
                .DefaultIfEmpty("N/A").FirstOrDefault();
            Console.WriteLine("result 2 : {0}", first);

            first = chars.Where(str => str.Length > 1)
                .DefaultIfEmpty().First();
            Console.WriteLine("result 3 : {0}", first);

            // Using in Left Joins:
            var leftSequence = new List<int>() { 99, 100, 5, 20, 102, 105 };
            var rightSequence = new List<char>() { 'a', 'b', 'c', 'i', 'd' };

            var numbersAsChars = from left in leftSequence
                                 join r in rightSequence
                                 on left equals (int)r into leftjoin
                                 from result in leftjoin.DefaultIfEmpty('?')
                                 select new
                                 {
                                     Number = 1,
                                     Character = result
                                 };

            foreach(var item in numbersAsChars)
            {
                Console.WriteLine("Num ={0} ** Char = {1}",item.Number, item.Character);
            }

            var leftSequence1 = new List<int> { 1, 2, 5 };
            var rightSequence1 = new List<dynamic>()
             {
             new { Value = 1 },
             new { Value = 2 },
             new { Value = 3 },
             new { Value = 4 },
             };
            var numbersAsChars1 = (from l in leftSequence1
                                  join r in rightSequence1
                                  on l equals r.Value into leftJoin
                                  from result in leftJoin.DefaultIfEmpty()
                                  select new
                                  {
                                      Left = l,
                                      // 5 will not have a matching object in the right so result
                                      // will be equal to null.
                                      // To avoid an error use:
                                      // - C# 6.0 or above - ?.
                                      // - Under - result == null ? 0 : result.Value
                                      Right = result?.Value
                                  }).ToList();

            foreach (var item in numbersAsChars1)
            {
                Console.WriteLine("Left ={0} ** Right = {1}", item.Left, item.Right);
            }
        }
    }
}
