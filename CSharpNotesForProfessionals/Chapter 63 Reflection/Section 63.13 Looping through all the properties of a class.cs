using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_13
    {
        public Section_63_13()
        {
            var obj = new Listproperty();
            obj.Name = "johan";
            obj.Value = "23";
            var t = obj.GetType();
            BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            PropertyInfo[] properties = t.GetProperties(flags);

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Name: " + property.Name + ", Value: " + property.GetValue(obj, null));
            }

        }
    }

    public class Listproperty
    {
        public Listproperty()
        {
        }

        public void Method1()
        {

        }

        public string Name { get; set; }

        public string Value { get; set; }

        protected void Method2()
        {
        }
    }
}
