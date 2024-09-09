using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_16
{
    public class MyClass
    {
        int a;
        object b;
        void set_a(int a)
        {
            this.a = a;
        }

        public MyClass(int arg,object addiionalArg)
        {
            this.a = arg;
            this.b = addiionalArg;
        }

        public MyClass(int arg) : this(arg, null)
        {

        }
    }
    
}
