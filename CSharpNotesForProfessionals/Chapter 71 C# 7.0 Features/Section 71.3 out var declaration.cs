using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    internal class Section_71_3
    {
        public Section_71_3()
        {
            string input = "10";
            int value;
            if (int.TryParse(input, out value))
            {
                Console.WriteLine(value); // ok
            }
            else
            {
                Console.WriteLine(value); // value is zero
            }
            Console.WriteLine(value); // ok



            if (int.TryParse(input, out int value1))
            {
                Console.WriteLine(value1); // ok
            }
            else
            {
                Console.WriteLine(value1); // value is zero
            }
            Console.WriteLine(value1); // ok


            //p.GetCoordinates(out var x, out _); // I only care about x

            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var groupedByMod2 = a.Select(x => new
            {
                Source = x,
                Mod2 = x % 2
            })
             .GroupBy(x => x.Mod2)
             .ToDictionary(g => g.Key, g => g.ToArray());
            if (groupedByMod2.TryGetValue(1, out var oddElements))
            {
                Console.WriteLine(oddElements.Length);
            }

            // Limitations

            //var nums =
            // from item in seq
            // let success = int.TryParse(item, out var tmp)
            // select success ? tmp : 0; // Error: The name 'tmp' does not exist in the current context
        }
    }
}
