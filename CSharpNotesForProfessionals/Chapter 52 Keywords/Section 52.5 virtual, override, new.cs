using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_5
{
    internal class BaseClass
    {
        public virtual void Foo()
        {
            Console.WriteLine("Foo from BaseClass");
        }
    }

    internal class DerivedClass : BaseClass
    {
        public override void Foo()
        {
            //base.Foo();
            Console.WriteLine("Foo from DerivedClass");
        }
    }

    internal class SecondDerivedClass : DerivedClass
    {

    }

    internal class BaseClass1
    {
        public void Foo()
        {
            Console.WriteLine("Foo from BaseClass1");
        }
    }
    internal class DerivedClass1 : BaseClass1
    {
        //public void Foo() {
        //    Console.WriteLine("Foo from DerivedClass1");
        //}

        public void Foo()
        {
            Console.WriteLine("Foo from DerivedClass1");
        }
    }

    public class A
    {
        public void Foo()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public new virtual void Foo()
        {
            Console.WriteLine("B");
        }
    }

    //public class C
    //{
    //    private virtual void Foo() 
    //    {
    //    }
    //}

}
