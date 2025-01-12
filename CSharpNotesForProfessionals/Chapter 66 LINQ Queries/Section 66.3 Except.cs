using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    public class Section_66_3
    {
        public Section_66_3()
        {
            int[] first = { 1, 1, 2, 3, 4, 4 };
            int[] second = { 0, 2, 3, 5 };

            IEnumerable<int> inFirstButNotInSecond = first.Except(second);

            foreach (var lop in inFirstButNotInSecond)
            {
                Console.WriteLine(lop);
            }


            var listPeople = new List<People>();
            listPeople.Add(new People { Name = "Sahrun", Age = 30 });
            listPeople.Add(new People { Name = "Sahrun", Age = 40 });
            listPeople.Add(new People { Name = "Agung", Age = 20 });
            listPeople.Add(new People { Name = "Jon", Age = 30 });
            listPeople.Add(new People { Name = "Andik", Age = 40 });
            listPeople.Add(new People { Name = "Joy", Age = 20 });

            var listPeople2 = new List<People>();
            listPeople2.Add(new People { Name = "Jon", Age = 30 });
            listPeople2.Add(new People { Name = "Andik", Age = 40 });
            listPeople2.Add(new People { Name = "Joy", Age = 20 });

            IEnumerable<People> inFirstButNotInSecond2 = listPeople.ExceptBy(listPeople2.Select(x => x.Name), x => x.Name);

            foreach (var lop in inFirstButNotInSecond2)
            {
                Console.WriteLine(lop.Name);
            }

            // Implement IEquetable
            Console.WriteLine("Implement IEquetable");

            List<HollyDay> holidayDifference = new List<HollyDay>();

            List<HollyDay> remoteHollyDays = new List<HollyDay>
            {
                new HollyDay { Name = "Xmas" },
                new HollyDay { Name = "Hanukkah" },
                new HollyDay { Name = "Ramadan" }

            };

            List<HollyDay> localHollyDays = new List<HollyDay>
            {
                new HollyDay { Name = "Xmas" },
                new HollyDay { Name = "Ramadan" }

            };

            holidayDifference = remoteHollyDays.Except(localHollyDays).ToList();

            holidayDifference.ForEach(x => Console.WriteLine(x.Name));
        }
    }

    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class HollyDay : IEquatable<HollyDay>
    {
        public string Name { get; set; }

        public bool Equals(HollyDay? other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }

    }
}
