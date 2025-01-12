using System.Security.Cryptography.X509Certificates;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_6
    {
        internal Section_66_6()
        {
            var first = new List<string>() { "a", "b", "c" };
            var second = new List<string>() { "a", "c", "d" };

            // (Inner) Join
            Console.WriteLine("(Inner) Join");
            var result = from f in first
                         join s in second on f equals s
                         select new { f, s };


            result = first.Join(second,
                                f => f,
                                s => s,
                                (f, s) => new { f, s });

            foreach (var item in result)
            {
                Console.WriteLine($"first : {item.f} second : {item.s}");
            }

            // Left outer join
            Console.WriteLine("Left outer join");
            var leftOuterJoin = from f in first
                                join s in second on f equals s into temp
                                from t in temp.DefaultIfEmpty()
                                select new { First = f, Second = t };
            // Or can also do: 
            leftOuterJoin = from f in first
                            from s in second.Where(x => x == f).DefaultIfEmpty()
                            select new { First = f, Second = s };

            Console.WriteLine("First  |  Second");

            foreach (var item in leftOuterJoin)
            {
                Console.WriteLine($"    {item.First}    |  {item.Second}");
            }

            // left outer join method syntax
            var leftOuterJoinFluentSyntax = first.GroupJoin(second,
                f => f,
                s => s,
                (f, s) => new { First = f, Second = s })
                .SelectMany(temp => temp.Second.DefaultIfEmpty(),
                (f, s) => new { First = f.First, Second = s });

            // Right Outer Join
            Console.WriteLine("Right Outer Join");
            var rightOuterJoin = from s in second
                                 join f in first on s equals f into temp
                                 from t in temp.DefaultIfEmpty()
                                 select new { First = t, Second = s };

            Console.WriteLine("First | Second");
            foreach (var item in rightOuterJoin)
            {
                Console.WriteLine($"{item.First}    |  {item.Second}");
            }

            // Cross Join
            Console.WriteLine("Cross Join");
            var CrossJoin = from f in first
                            from s in second
                            select new { f, s };

            foreach (var item in CrossJoin)
            {
                Console.WriteLine($"{{first:'{item.f}',second:'{item.s}'}}");
            }

            // Full Outer Join 
            Console.WriteLine("Full Outer Join");
            var fullOuterjoin = leftOuterJoin.Union(rightOuterJoin);



            foreach (var item in fullOuterjoin)
            {
                Console.WriteLine($"{item.First},{item.Second}");
            }

            // Example
            Console.WriteLine("Example");
            Example();


        }

        private void Example()
        {
            var first = new List<Region>()
            { new Region(1),new Region(3), new Region(4)};

            var second = new List<Region>()
            {
                new Region(1, "Eastern"), new Region(2, "Western"),
                new Region(3, "Northern"), new Region(4, "Southern")
            };

            var result = from f in first
                         join s in second on f.ID equals s.ID
                         select new { f.ID, s.RegionDescription };

            foreach (var item in result)
            {
                Console.WriteLine($"Region Id : {item.ID.ToString()} \n Regin : {item.RegionDescription}");
            }
        }
    }

    public class Region
    {
        public Int32 ID;
        public string RegionDescription;

        public Region(Int32 pRegionID, string pRegionDescription = null)
        {
            ID = pRegionID; RegionDescription = pRegionDescription;
        }
    }
}
