using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_19
{
    internal class Section_52_19
    {
        internal Section_52_19()
        {
            var lines = new string[]
            {
                "Hello word!",
                "how are you doing today?",
                "Goodbye"
            };

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            foreach (int number in numbers)
            {
                if (number == 2)
                    continue;

                if (number == 5)
                    break;

                Console.WriteLine(number + ",");
            }

        }
    }
}

