using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_13
    {
        public Section_66_13()
        {
            int[] intList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = intList.Aggregate((prevSum, current) => prevSum + current);

            Console.WriteLine(sum);

            string[] stringList = { "Hello", "World", "!" };
            string joinedString = stringList.Aggregate((prev, current) => prev + " " + current);
            // joinedString = "Hello Word !"
            Console.WriteLine(joinedString);

            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var result = items.Aggregate(new { Total = 0, Even = 0, FourthItems = new List<int>() },

                (accumelative, item) => new
                {
                    Total = accumelative.Total + 1,
                    Even = accumelative.Even + (item % 2 == 0 ? 1 : 0),
                    FourthItems = (accumelative.Total + 1) % 4 == 0 ?
                    new List<int>(accumelative.FourthItems) { item } : accumelative.FourthItems

                });


            Console.WriteLine("Total : {0}", result.Total);
            Console.WriteLine("Event : {0}", result.Even);
            Console.WriteLine("FourthItems:{0} ", string.Join(",", result.FourthItems));


        }
    }
}
