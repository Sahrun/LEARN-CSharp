using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_43
    {
        public Section_66_43()
        {
            // All 
            int[] array = { 10, 20, 30 };

            // Are all elements >= 10? YES
            array.All(element => element >= 10);

            // Are all elements >= 20? NO
            array.All(element => element >= 20);

            // Are all elements < 40? YES
            array.All(element => element < 40);

            // Any
            int[] query = new int[] { 2, 3, 4 };
            query.Any(n => n == 3);

            // Contains
            //for int array
            int[] query1 = new int[] { 1, 2, 3 };
            query.Contains(1);
            //for string array
            string[] query2 = { "Tom", "grey" };
            query2.Contains("Tom");
            //for a string
            var stringValue = "hello";
            stringValue.Contains("h");


        }
    }
}
