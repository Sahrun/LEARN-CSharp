using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_27
    {
        public Section_66_27()
        {
            string[] names = { "mark", "steve", "adam" };

            // Ascending
            // Query Syntax
            var shortedNames =
                from name in names
                orderby name
                select name;

            // method
            shortedNames = names.OrderBy(name => name);


            // Descending:
            // query
            shortedNames =
               from name in names
               orderby name descending
               select name;
            // method sintax 

            shortedNames = names.OrderByDescending(name => name);

            // Order by several fields
            Orang[] people =
                {
                 new Orang { FirstName = "Steve", LastName = "Collins", Age = 30},
                 new Orang { FirstName = "Phil" , LastName = "Collins", Age = 28},
                 new Orang { FirstName = "Adam" , LastName = "Ackerman", Age = 29},
                 new Orang { FirstName = "Adam" , LastName = "Ackerman", Age = 15}
                };

            var sortedPeople = from person in people
                               orderby person.LastName, person.FirstName, person.Age descending
                               select person;

            sortedPeople = people.OrderBy(person => person.LastName)
                .ThenBy(person => person.FirstName)
                .ThenByDescending(person => person.Age);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.FirstName, person.LastName, person.Age.ToString());
            }

        }
    }

    public class Orang
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
