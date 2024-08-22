using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_6
{
    public static class IntExtensions
    {
        public static int Increment(this int number)
        {
            return ++number;
        }

        public static int Decrement(this int number)
        {
            return --number;
        }

        public static int[] WhereEven(this int[] array)
        {
            //Enumerable.* extension methods use a fluent approach
            return array.Where(x => (x % 2) == 0).ToArray();
        }

        public static int[] WhereGreaterThen(this int[] array,int value)
        {
            return array.Where(i => i > value).ToArray();
        }
    }
}
