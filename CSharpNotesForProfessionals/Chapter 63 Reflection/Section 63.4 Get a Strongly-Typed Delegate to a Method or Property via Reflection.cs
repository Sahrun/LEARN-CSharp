using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_4
    {
        public Section_63_4()
        {
            var maxMethod = typeof(Math).GetMethod("Max", new Type[] { typeof(int), typeof(int) });

            var stronglyTypeDelegate = (Func<int, int, int>)Delegate.CreateDelegate(typeof(Func<int, int, int>), null, maxMethod);

            Console.WriteLine("Max of 3 and 5 is: {0}", stronglyTypeDelegate(3, 5));


            MyClass target = new MyClass { MyIntProperty = 1 };
            // getter
            var theProperty = typeof(MyClass).GetProperty("MyIntProperty");
            var theGetter = theProperty.GetGetMethod();
            var stronglyTypeGetter = (Func<MyClass, int>)Delegate.CreateDelegate(typeof(Func<MyClass, int>), theGetter);

            Console.WriteLine("target.MyIntproperty id : {0}", stronglyTypeGetter(target));


            // setter
            var theSetter = theProperty.GetSetMethod();
            var stronglyTypedSetter = (Action<MyClass, int>)Delegate.CreateDelegate(typeof(Action<MyClass, int>), theSetter);
            stronglyTypedSetter(target, 5);

            Console.WriteLine("target.MyIntproperty id : {0}", target.MyIntProperty);
        }
    }

    public class MyClass
    {
        public int MyIntProperty { get; set; }
        private int MyPrivateProperty { get; set; }
    }
}
