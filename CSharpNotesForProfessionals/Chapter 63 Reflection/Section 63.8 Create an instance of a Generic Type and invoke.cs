using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_8
    {
        public Section_63_8()
        {
            var baseType = typeof(List<>);
            var genericType = baseType.MakeGenericType(typeof(String));
            var instance = Activator.CreateInstance(genericType);
            var method = genericType.GetMethod("GetHashCode");
            var result = method.Invoke(instance, new object[] { });
        }
    }
}
