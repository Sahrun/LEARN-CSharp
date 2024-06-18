using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Section6._4EqualsandGetHashCodeinIEqualityComparator
{
    public class PersonComparator : IEqualityComparer<Person>
    {
        public bool Equals(Person? x, Person? y)
        {
           return x?.Name == y?.Name && x?.Age == y?.Age;
        }

        public int GetHashCode(Person obj)
        {
           return obj.Name.GetHashCode() * obj.Age;
        }
    }
}
