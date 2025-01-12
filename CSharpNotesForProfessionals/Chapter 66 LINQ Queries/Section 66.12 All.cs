using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_12
    {
        internal Section_66_12()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = numbers.All(i => i < 10);
            Console.WriteLine($"ALl numbers < 10 ? ({result})");
            result = numbers.All(i => i >= 3);
            Console.WriteLine($"All numbers >=3 ? ({result})");
            numbers = new List<int>();
            result = numbers.All(i => i >= 5);
            Console.WriteLine($"All numbers >= 5? ({result})");

        }
    }
}
