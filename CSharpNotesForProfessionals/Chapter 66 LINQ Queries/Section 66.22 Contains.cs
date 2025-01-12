using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_22
    {
        public Section_66_22()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var result1 = numbers.Contains(4); // true
            var result2 = numbers.Contains(8); // false

            List<int> secondNumberCollection = new List<int> { 4, 5, 6, 7 };

            var result3 = secondNumberCollection.Where(item => numbers.Contains(item)).ToList();

            result3.ForEach(item => { Console.Write(item); });

            // Object

            List<Camel> objects = new List<Camel>
            {
                 new Camel { Name = "Nikki"},
                 new Camel { Name = "Gilad"},
                 new Camel { Name = "Phil"},
                 new Camel { Name = "John"}
            };

            var result4 = objects.Contains(new Camel { Name = "Phil" }); // true

            // Using the Enumerable.Contains(value,comparer) overload:
            var result5 = objects.Contains(new Camel { Name = "Phil" }, new Compare());

            // A smart usage of Contains would be to replace multiple if clauses to a Contains call.
            if (new int[] { 1, 3, 4 }.Contains(1))
            {
                Console.WriteLine("test");
            }

        }
    }

    public class Camel
    {
        public string Name { get; set; }
    }

    public class Compare : IEqualityComparer<Camel>
    {
        public bool Equals(Camel? x, Camel? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Camel obj)
        {
            return obj.Name.GetHashCode();
        }
    }


}
