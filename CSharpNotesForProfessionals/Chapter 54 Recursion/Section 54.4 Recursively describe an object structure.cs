using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_54_Recursion_Section_54_4
{
    public class Root
    {
        public string Name { get; set; }
        public ChildOne Child { get; set; }
    }

    public class ChildOne
    {
        public string ChildOneName { get; set; }
        public ChildTwo Child { get; set; }
    }

    public class ChildTwo
    {
        public string ChildTwoName { get; set; }
    }

    public class Program
    {

      public  static void Main(string[] args)
        {
            DescribeTypeOfObject(typeof(Root));
            Console.WriteLine("Press a key to exist:");
            Console.ReadKey();
        }

        static void DescribeTypeOfObject(Type type)
        {
            Console.WriteLine($"Describing type {type.Name}");
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo pi in propertyInfos)
            {
                Console.WriteLine($"Has property {pi.Name} of type {pi.PropertyType.Name}");

                if(pi.PropertyType.IsClass && !pi.PropertyType.FullName.StartsWith("System."))
                {
                    DescribeTypeOfObject(pi.PropertyType);
                }
            }
        }
    }
}
