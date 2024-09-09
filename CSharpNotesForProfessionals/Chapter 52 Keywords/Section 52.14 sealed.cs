using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_14
{
    internal class A {
        public sealed override string ToString() // Virtual method inherited from class Object
        {
            return "Do not override me!";
        }
    }
    sealed class B : A {
        //public override string ToString() // Compile time error
        //{
        //    return "An attempt to override";
        //}
    }
    //class C : B { }
}
