using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter_58_Inheritance_Section_58_8
{
    internal interface IBaseInterface { }
    class BaseClass : IBaseInterface { };

    internal interface DerivedInterface { }

    internal class DerivedClass : BaseClass, DerivedInterface { }



    internal class NavigationInheritance
    {
        internal NavigationInheritance()
        {

            var baseInterfaseType = typeof(IBaseInterface);
            var drivedInterfaceType = typeof(DerivedInterface);
            var baseType = typeof(BaseClass);
            var drivedType = typeof(DerivedClass);

            var baseIntance = new BaseClass();
            var derivedInstance = new DerivedClass();

            WriteLine(derivedInstance is DerivedClass);
            WriteLine(derivedInstance is DerivedInterface);
            WriteLine(derivedInstance is BaseClass);
            WriteLine(derivedInstance is IBaseInterface);
            WriteLine(derivedInstance is object);

            WriteLine(drivedType.BaseType.Name);
            WriteLine(baseType.BaseType.Name);
            WriteLine(typeof(object).BaseType);


            WriteLine(baseType.IsInstanceOfType(derivedInstance));
            WriteLine(drivedType.IsInstanceOfType(baseIntance));


            WriteLine(String.Join(",", drivedType.GetInterfaces().Select(t => t.Name).ToArray()));

            WriteLine(baseInterfaseType.IsAssignableFrom(drivedType));
            WriteLine(drivedInterfaceType.IsAssignableFrom(drivedType));
            WriteLine(drivedInterfaceType.IsAssignableFrom(baseType));




        }
    }
}
