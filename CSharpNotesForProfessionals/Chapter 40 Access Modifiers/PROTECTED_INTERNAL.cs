using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_40_Access_Modifiers_protected_internal
{
    public class Foo
    {
        public string MyPublicProperty { get; set; }
        protected internal string MyprotectedInternalProperty { get; set; }

        protected internal class MyprotectedInternalNestedClass
        {
            private string blah;
            public int N { get; set; }
        }

    }

    public class Bar {
        void Mymethod1()
        {
            Foo foo = new Foo();
            var myPublicProperty = foo.MyPublicProperty;
            var myProectedInternalProperty = foo.MyprotectedInternalProperty;
            var myprotectedInternalNetedIntance = new Foo.MyprotectedInternalNestedClass();
        }

     
    }

}
