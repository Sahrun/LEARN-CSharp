using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section6._2DefaultEqualsbehavior
{
    public class DefaultEqualsbehavior
    {
        public DefaultEqualsbehavior() {
            Foo fooClass1 = new Foo("42");
            Foo fooClass2 = new Foo("42");

            bool areFooClassEqual = fooClass1.Equals(fooClass2);

            Console.WriteLine("fooClass1 and fooClass2 are equa : {0}", areFooClassEqual);

            int fooInt1 = 42;
            int fooInt2 = 42;
            bool areFooIntEqual = fooInt1.Equals(fooInt2);
            Console.WriteLine("fooInt1 and fooInt2 are equal: {0}", areFooIntEqual);

            string fooString1 = "42";
            string fooString2 = "42";

            bool areFooStringEqual = fooString1.Equals(fooString2);
            Console.WriteLine("fooString1 and fooString2 are equal: {0}", areFooStringEqual);

        }
    }
}
