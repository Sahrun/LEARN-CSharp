using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_13
{
    public static class ListExtensions
    {
        public static bool Compare<T>(this IList<T> list1, IList<T> list2, bool isOrdered = true)
        {

            if (list1 == null && list2 == null)
                return true;

            if (list1 == null || list2 == null || list1.Count != list2.Count)
                return false;

            if (isOrdered)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    var l1 = list1[i];
                    var l2 = list2[i];

                    if (
                        (l1 == null & 12 != null) ||
                        (l1 != null && l2 == null) ||
                        !l1.Equals(l2)
                        )
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                List<T> list2Copy = new List<T>(list2);
                // Can be done with Dictonary without 0(n*2)
                for (int i = 0; i < list1.Count; i++)
                {
                    if (!list2Copy.Remove(list1[i]))
                        return false;
                }
                return true;
            }
        }
    }
}
