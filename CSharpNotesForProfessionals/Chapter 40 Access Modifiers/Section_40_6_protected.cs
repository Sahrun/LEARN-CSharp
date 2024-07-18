using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_40_Access_Modifiers_Section_40_6_protected
{
    public class Foo()
    {
        protected void SomeFooMethod()
        { 
        
        }


        protected class Thing {
            private string blah;
            public int N {  get; set; }
        }
    
    }

    public class Bar() : Foo {
        private void sameBarMethod()
        { 
            SomeFooMethod();
            var thing = new Thing();
        }
    }

    public class Baz()
    { 
    private void someBazmethod()
        {
            var foo = new Foo();
            foo.SomeFooMethod();

        }
    }
}
