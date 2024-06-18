using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section6._3OverrideEqualsandGetHashCodeoncustom
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Clothes { get; set; }

        public Person(string name, int age, string clothes)
        {
            Name = name;
            Age = age;
            Clothes = clothes;
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            if (person == null) return false;
            return Name == person.Name && Age == person.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()*Age;
        }



    }
}
