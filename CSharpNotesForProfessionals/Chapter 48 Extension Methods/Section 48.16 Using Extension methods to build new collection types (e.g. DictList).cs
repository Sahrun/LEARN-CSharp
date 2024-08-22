using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_16
{
    public static class DictListExtensions
    {
        public static void Add<Tkey, TValue, TCollection>(this Dictionary<Tkey, TCollection> dict, Tkey key, TValue value)
            where TCollection : ICollection<TValue>, new()
        {
            TCollection list;

            if (!dict.TryGetValue(key, out list))
            {
                list = new TCollection();
                dict.Add(key, list);
            }

            list.Add(value);
        }

        public static bool Remove<Tkey, TValue, TCollection>(this Dictionary<Tkey, TCollection> dict, Tkey key, TValue value) where TCollection : ICollection<TValue>
        {

            TCollection list;
            if (!dict.TryGetValue(key, out list))
            {
                return false;
            }

            var ret = list.Remove(value);

            if (list.Count == 0)
            {
                dict.Remove(key);
            }

            return ret;
        }
    }
}
