using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_9
    {
        public Section_63_9()
        {
            Type t = typeof(SampleClass);


            // Get properties with MyAttribute
            var props = t.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Where(
                            prop => Attribute.IsDefined(prop, typeof(MyAttribute)));

            // Print the results
            foreach (var prop in props)
            {
                Console.WriteLine($"Property: {prop.Name}");
            }
            var allAttributes = t.GetProperty("Name").GetCustomAttributes(false);


            foreach (var attr in allAttributes)
            {
                var st = attr as MyAttribute;
                Console.WriteLine(st.Desc);
            }

            var assembly = Assembly.GetExecutingAssembly();
            var typesAsm = GetTypesWithAttribute(assembly);
            foreach (var item in typesAsm)
            {
                var attr = (MyAttribute)item.GetCustomAttribute(typeof(MyAttribute), true);

                Console.WriteLine(attr.Desc);
            }

            // Read value of a custom attribute at runtime

            var Attributecus = typeof(SampleClass).GetAttribute("MyMethodName", (DescriptionAttribute d) => d.Description);
            Console.WriteLine(Attributecus);

        }


        static IEnumerable<Type> GetTypesWithAttribute(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(typeof(MyAttribute), true).Any())
                {
                    yield return type;
                }
            }
        }
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        public class MyAttribute : Attribute
        {
            public string Desc { get; }
            public MyAttribute(string desc)
            {
                this.Desc = desc;
            }
            public MyAttribute()
            {

            }
        }

        public class SampleClass
        {
            [MyAttribute("Att1")]
            [MyAttribute("Att2")]
            public string? Name { get; set; }

            [MyAttribute("Desc")]
            public string? Description { get; set; }

            [MyAttribute]
            public string? MyProperty { get; set; }

            //private int MyField; // Not a property, won't be included.

            [MyAttribute]
            private string? PrivateProperty { get; set; }

            public string AnotherProperty { get; set; }

            [Description("desc")]
            public void MyMethodName()
            {
                Console.WriteLine("MyMethodName");
            }

        }
    }


    public static class AttributeExtensions
    {
        public static TValue GetAttribute<TAttribute, TValue>(this Type type, string MemberName, Func<TAttribute, TValue> valueSelector, bool inherit = false) where TAttribute : Attribute
        {
            var att =type.GetMember(MemberName).FirstOrDefault().GetCustomAttributes(typeof(TAttribute),
 inherit).FirstOrDefault() as TAttribute;
            if (att != null)
            {
                return valueSelector(att);
            }
            return default(TValue);

        }
    }
}
