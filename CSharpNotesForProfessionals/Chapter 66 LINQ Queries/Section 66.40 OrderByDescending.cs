using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_40
    {
        public Section_66_40()
        {
            int[] numbers = { -2, -1, 0, 1, 2 };
            IEnumerable<int> descending = numbers.OrderByDescending(x => x);
            // returns {2, 1, 0, -1, -2}

            char[] letters = { ' ', '!', '?', '[', '{', '+', '1', '9', 'a', 'A', 'b', 'B', 'y', 'Y', 'z', 'Z' };
            IEnumerable<char> descending1 = letters.OrderByDescending(x => x);
            // returns { '{', 'z', 'y', 'b', 'a', '[', 'Z', 'Y', 'B', 'A', '?', '9', '1', '+', '!', ' ' }

            var people = new[]
               {
                 new Person3 {Name = "Alice", Age = 25},
                 new Person3 {Name = "Bob", Age = 21},
                 new Person3 {Name = "Carol", Age = 43}
                };

            var oldestPerson = people.OrderByDescending(x => x.Age).First();
            var name = oldestPerson.Name; // Carol

        }
    }

    class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
