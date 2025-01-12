using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_12
    {
        public Section_63_12()
        {
            var list1 = new List<int>();
            var list2 = new Dictionary<int, string>();
            ShowgenericArgument(list1);
            ShowgenericArgument(list2);
        }


        public void ShowgenericArgument(object o)
        {
            if (o == null) return;

            Type t = o.GetType();

            if (!t.IsConstructedGenericType) return;

            foreach (Type t2 in t.GetGenericArguments())
            {
                Console.WriteLine(t2.Name);
            }
        }
    }
}
