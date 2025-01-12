using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_16
    {
        public Section_66_16() { 
            List<int> iLists = new List<int>() { 1,2,3,4,5,6,7,8,9};

            var grouped = iLists.GroupBy(x => x);

            foreach (var group in grouped) {
                foreach (var item in group)
                {
                    Console.WriteLine(item); // 
                }
            }

            // More Complex Example

            List<Person> people = new List<Person>();
            people.Add(new Person { Age = 20, Name = "Mouse" });
            people.Add(new Person { Age = 30, Name = "Neo" });
            people.Add(new Person { Age = 40, Name = "Morpheus" });
            people.Add(new Person { Age = 30, Name = "Trinity" });
            people.Add(new Person { Age = 40, Name = "Dozer" });
            people.Add(new Person { Age = 40, Name = "Smith" });

            var query = people.GroupBy(x => x.Age);


            foreach (var item in query) {
                Console.WriteLine(item.Key);
                foreach(var person in item)
                {
                    Console.WriteLine(person.Name);
                }
            }


        }
    }

    public class Person1
    {
        public int Age { get; set; }
        public int Name { get; set; }
    }
}
