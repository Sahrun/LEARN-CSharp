using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section6._3OverrideEqualsandGetHashCodeoncustom
{
    public class OverrideEqualsandGetHashCodeoncustom
    {
        public OverrideEqualsandGetHashCodeoncustom()
        {
            var person1 = new Person("Jon", 20, "some clothes");
            var person2 = new Person("Jon", 20, "some other clothes");

            bool result = person1.Equals(person2);

            Console.WriteLine("person1 and person2 is same {0}", result);

            var persons = new List<Person>()
            {
                new Person("Jon",20,"some clothes" ),
                new Person("Dave", 20,"same other clothes"),
                new Person("Jon",20,"")
            };

            var distinctPersons = persons.Distinct().ToList();

            Console.WriteLine("Total persons unique is {0} because following equals from this class", distinctPersons.Count);


        }
    }


}
