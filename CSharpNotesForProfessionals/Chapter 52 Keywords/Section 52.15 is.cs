using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_15
{
   internal interface BaseInterface { }
   internal class BaseClass : BaseInterface { }

   internal class DerivedClass : BaseClass { }

    internal class TheMainClass {
        internal void Main() {
            var d = new DerivedClass();
            Console.WriteLine(d is DerivedClass);
            Console.WriteLine(d is BaseClass);
            Console.WriteLine(d is BaseInterface);
            Console.WriteLine(d as object);
            Console.WriteLine(d is string);

            var b = new BaseClass();
            Console.WriteLine(b is DerivedClass);
            Console.WriteLine(b is BaseClass);

            Console.WriteLine(b is BaseInterface);
            Console.WriteLine(b is object);
            Console.WriteLine(b is string);

            var d = new DerivedClass();
            Console.WriteLine(d is DerivedClass);
            Console.WriteLine(d is BaseClass);

            if(d is BaseClass)
            {
                var castedD = (BaseClass)d;
                castedD.Method();
            }

            var asD = d as BaseClass;
            if (asD != null)
            {
                asD.Method();
            }

            // Version > 7.0
            if(d is DerivedClass asD)
            {
                asD.Method();
            }
        }
    }
}
