using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_40_Access_Modifiers
{
    public class Foo
    {
        public string SomeProperty { get; set; }
        public class Baz
        {
            public int Value { get; set; }
        }
    }
    public class Bar
    {
        public Bar()
        {
            var myInstance = new Foo();
            var someValue = myInstance.SomeProperty;
            var myNestedInstance = new Foo.Baz();
            var otherValue = myNestedInstance.Value;
        }
    }
}
