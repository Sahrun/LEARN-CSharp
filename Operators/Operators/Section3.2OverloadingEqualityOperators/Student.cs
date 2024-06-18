using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section3._2OverloadingEqualityOperators
{
    public class Student : IEquatable<Student>
    {
        public string Name { get; set; } = "";

        public bool Equals(Student? other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as Student);
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Student left, Student right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Student left, Student right)
        {
            return !Equals(left, right);
        }
    }

}
