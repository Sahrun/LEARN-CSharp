using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_8
    {
        internal Section_66_8()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var aboveAverages = from number in numbers
                                let average = numbers.Average()
                                let nSquared = Math.Pow(number, 2)
                                where nSquared > average
                                select new { number = number, average = average };

            Console.WriteLine("The average of the numbers is {0}", numbers.Average());

            foreach (var item in aboveAverages)
            {
                Console.WriteLine($"Query result includes number {item.number} with square of {Math.Pow(item.number, 2)} average: {item.average} ");
            }
        }
    }
}

