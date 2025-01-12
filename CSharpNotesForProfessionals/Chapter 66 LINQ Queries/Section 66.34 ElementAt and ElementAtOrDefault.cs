using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_34
    {
        public Section_66_34()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
           
            Console.WriteLine("ElementAt on index 2 : {0}", numbers.ElementAt(2));
            Console.WriteLine("ElementAtOrDefault on index 2 : {0}", numbers.ElementAtOrDefault(2));
            Console.WriteLine("ElementAtOrDefault on index 10 : {0}", numbers.ElementAtOrDefault(10));


        }
    }
}
