using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    internal class Section_71_9
    {
        public Section_71_9()
        {
            new test();
        }

    }
    public  class test
    {
        public test() {
            Matrix3D left = new Matrix3D(), right = new Matrix3D();


            Choose(() => left.M20 > right.M20, ref left, ref right).M20 = 1.0;

            int a = 1, b = 2, c = 3;
            Max(ref a, ref b, ref c) = 4;
            Debug.Assert(a == 1); // true
            Debug.Assert(b == 2); // true
            Debug.Assert(c == 4); // true

        }
        public static ref TValue Choose<TValue>(
            Func<bool> condition, ref TValue left, ref TValue right)
        {
            return ref condition() ? ref left : ref right;
        }

        public static ref int Max(ref int first, ref int second, ref int third)
        {
            ref int max = ref (first > second ? ref first : ref second);
            return ref max > third ? ref max : ref third;
        }

    }

    public class Matrix3D
    {
        public double M20 { get; set; }
    }
}
