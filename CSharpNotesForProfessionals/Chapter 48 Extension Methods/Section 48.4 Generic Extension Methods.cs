using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_4_Generic_Extension_Methods
{
    static class Extensions
    {
        public static bool HasMoreThanThreeElements<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Take(4).Count() > 3;
        }

        public static TU GenericExt<T, TU>(this T obj)
        {
            TU ret = default(TU);

            return ret;
        }
        public static bool IsDefault<T>(this T obj) where T : struct, IEquatable<T>
        {
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

    }
    class Mytype<T1, T2>
    {

    }
    static class Extensions2
    {
        public static void Example<T>(this Mytype<int, T> test)
        {

        }
    }

   
}
