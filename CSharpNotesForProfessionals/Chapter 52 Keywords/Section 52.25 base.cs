using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_25
{
    internal class Section_52_25
    {
    }
    public class Child : SomeBaseClass
    {
        public Child() : base("message for same base class") { }
    }

    public class SomeBaseClass
    {
        public SomeBaseClass()
        {
        }

        public SomeBaseClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Parent
    {
        public virtual int virtualMethod()
        {
            return 1;
        }
    }

    public class Child1 : Parent {
        public override int virtualMethod() {
            return 11;
        }

        public int NumberMethod()
        {
            return base.virtualMethod();
        }

        public void CallMethods() {
            //Assert.AreEqual(11, VirtualMethod());
            //Assert.AreEqual(1, NormalMethod());
            //Assert.AreEqual(1, base.VirtualMethod());

        }

    }
}
