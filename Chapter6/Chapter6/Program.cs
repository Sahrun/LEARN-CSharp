using Chapter6.Section6._4EqualsandGetHashCodeinIEqualityComparator;

namespace Chapter6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Section 6.4: Equals and GetHashCode in IEqualityComparator ==");

            List<Person> persons = new List<Person> {
                new Person { Name = "Jon", Age=20, Clothes="some clothes"},
                new Person { Name = "Dave", Age=20,Clothes="some other clothes"},
                new Person { Name = "Jon", Age=20, Clothes=""}
            };

            var distinctPersons = persons.Distinct().ToList();

            Console.WriteLine("Distinct with liq total data : {0}", distinctPersons.Count);

            var distinctPerson2 = persons.Distinct(new PersonComparator()).ToList();

            Console.WriteLine("Distinct with IEqualityComparator total data : {0}", distinctPerson2.Count);

        }
    }
}