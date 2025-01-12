using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_5
    {
        public Section_63_5()
        {
            Sample sample = new Sample();
            MethodInfo method = typeof(Sample).GetMethod("Genericmethod");
            MethodInfo generic = method.MakeGenericMethod(typeof(string));
            generic.Invoke(sample, null);

            method = typeof(Sample).GetMethod("StaticMethod");
            generic = method.MakeGenericMethod(typeof(string));
            generic.Invoke(null, null);
        }
    }

    public class Sample
    {
        public void Genericmethod<T>()
        {
            Console.WriteLine("method void");
        }

        public static void StaticMethod<T>()
        {
            Console.WriteLine("method static");
        }
    }
}
