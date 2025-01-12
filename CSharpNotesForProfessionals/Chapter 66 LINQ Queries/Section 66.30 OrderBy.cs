using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_30
    {
        public Section_66_30()
        {
            int[] numbers = { 2, 1, 0, -1, -2 };
            IEnumerable<int> ascending = numbers.OrderBy(x => x);

            char[] letters = { ' ', '!', '?', '[', '{', '+', '1', '9', 'a', 'A', 'b', 'B', 'y', 'Y', 'z', 'Z' };
            IEnumerable<char> ascending1 = letters.OrderBy(x => x);

            var people = new[]
                {
                 new Person2 {Name = "Alice", Age = 25},
                 new Person2 {Name = "Bob", Age = 21},
                 new Person2 {Name = "Carol", Age = 43}
                };
            var youngestPerson = people.OrderBy(x => x.Age).First();
            var name = youngestPerson.Name; // Bo

        }
    }

    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
