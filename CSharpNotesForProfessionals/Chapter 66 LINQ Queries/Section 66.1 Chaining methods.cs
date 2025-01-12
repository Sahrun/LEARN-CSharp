using System;
using System.Collections.Generic;

namespace Chapter_66_LINQ_Queries
{
    // Delegate dengan dua parameter
    public delegate bool FilterDelegate(Person person, int max);

    public class Section_66_1
    {
        public Section_66_1()
        {
            var persons = new List<Person>
            {
                new Person { Age = 9, Name = "test" },
                new Person { Age = 10, Name = "test3" }
            };

            // Define max value
            int max = 8;

            // Delegate tetap digunakan
            FilterDelegate filterDelegate = filter;

            // Bungkus FilterDelegate agar max tidak perlu diteruskan ke extension method
            var personFilter = persons.Filter(person => filterDelegate(person, max));

            foreach (var person in personFilter)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            int[] someNumbers = { 4, 3, 2, 1 };
            var processed = someNumbers
             .Select(n => n * 2) // Multiply each number by 2
             .Where(n => n != 6) // Keep all the results, except for 6
             .OrderBy(n => n); // Sort in ascending order
        }

        // Metode filter tetap menerima dua parameter
        public static bool filter(Person person, int max)
        {
            return person.Age > max;
        }
    }

    public static class PersonExtension
    {
        // Tetap gunakan FilterDelegate untuk kompatibilitas
        public static IEnumerable<Person> Filter(this IEnumerable<Person> persons, Func<Person, bool> filter)
        {
            foreach (var item in persons)
            {
                if (filter(item))
                    yield return item;
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
