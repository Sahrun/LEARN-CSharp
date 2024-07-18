using Chapter_40_Access_Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_40_Access_Modifiers_PRIVATE
{
    public class Foo
    {
        private string someProperty { get; set; }

        private class Baz
        {
            public string value { get; set; }
        }
        public void Do()
        {
            var baz = new Baz { value = someProperty };
        }
    }


    public class Bar {

        public Bar()
        {
            var myInstance = new Foo();
            //var someValue = myInstance.someProperty;
            //var baz = new Foo.Baz;

            myInstance.Do();
        
        }
    }
}
