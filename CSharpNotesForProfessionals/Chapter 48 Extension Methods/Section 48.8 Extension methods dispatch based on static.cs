using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_8
{
    public class Base
    {
        public virtual string GetName()
        {
            return "Base";
        }
    }

    public class Derived : Base
    {
        public override string GetName()
        {
            return "Derived";
        }
    }

    public static class Extensions
    {
        public static string GetnameByExtension(this Base item)
        {
            return "Base";
        }

        public static string GetNameByExtension(this Derived item)
        {
            return "Derived";
        }
    }


    public class Person
    { 
        public string Name { get; set; }
    }

    public static class ExtensionPerson
    {
        public static string GetPersonName(this Person person)
        {
            return person.Name;
        }
    }
}
