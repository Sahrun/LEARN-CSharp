using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    internal class Section_71_1
    {
//        private readonly List<Tuple<string, string, string>> labels = new List<Tuple<string, string,
//string>>()
//{
// new Tuple<string, string, string>("test1", "test2", "Value"),
// new Tuple<string, string, string>("test1", "test1", "Value2"),
// new Tuple<string, string, string>("test2", "test2", "Value3"),
//};

//        private readonly List<(string firstThingy, string secondThingyLabel, string foundValue)> labels =
//       new List<(string firstThingy, string secondThingyLabel, string foundValue)>()
//       {
// ("test1", "test2", "Value"),
// ("test1", "test1", "Value2"),
// ("test2", "test2", "Value3"),
//       };
        public Section_71_1()
        {
            var result = GetTallies();
            Console.WriteLine("Result 1 : {0}", result.sum);
            Console.WriteLine("Result 2 : {0}", result.count);

            Console.WriteLine("Tuple Deconstruction");
            (int tallyOne, int tallyTwo) = GetTallies();
            Console.WriteLine("Output 1: {0}", tallyOne);
            Console.WriteLine("Output 2: {0}", tallyTwo);

            (var s, var c) = GetTallies();

            var (d, e) = GetTallies();

            int f, g;
            (f, g) = GetTallies();

            (g, f) = (f, g);

            var person = new Person { FirstName = "John", LastName = "Smith" };
            var (localFirstName, localLastName) = person;

            var (localFirstName1, localLastNamew) = person;


            var person1 = new Person1(("Jane", "Smith"));
            var firstName = person1.Name.First; // "Jane"
            var lastName = person1.Name.Last; // "Smith"

            Console.WriteLine("Tuple Initialization");

            var name = ("John", "Smith");
            Console.WriteLine(name.Item1);
            Console.WriteLine(name.Item2);

            var name1 = (first: "John", middle: "Q", last: "Smith");
            Console.WriteLine(name1.first);

            Console.WriteLine("Type inference");
            var (oup1, oupt2) = Measure([1,4,6,7]);

            Console.WriteLine("Reflection and Tuple Field Names");

            Console.WriteLine("Use with generics and async");
        }

        public (int sum, int count) GetTallies()
        {
            return (1, 2);
        }

        public (int sum, double average) Measure(List<int> items)
        {
            var stats = (sum: 0, average: 0d);
            stats.sum = items.Sum();
            stats.average = items.Average();
            return stats;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
        
    }

    public class Person1
    {
        public (string First, string Last) Name { get; }
        public Person1((string FirstName, string LastName) name)
        {
            Name = name;
        }
    }

    public static class PersonExtensions
    {
        public static void Deconstruct(this Person person, out string firstName, out string lastName)
        {
            firstName = person.FirstName;
            lastName = person.LastName;
        }
    }


}
