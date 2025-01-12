using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection_Section_63_1
{
    internal class GetmemberList
    {
        public GetmemberList()
        {
            var members = typeof(object).GetMembers(BindingFlags.Public |
                                                    BindingFlags.Static |
                                                    BindingFlags.Instance);

            foreach (var member in members)
            {
                bool inherited = member.DeclaringType.Equals(typeof(object).Name);
                Console.WriteLine($"{member.Name} is a {member.MemberType}, " +
                                  $"it has {(inherited ? "" : "not")} been inherited  ");
            }
        }
    }
}
