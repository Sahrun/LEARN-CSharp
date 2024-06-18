namespace Chapter_23_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 23: Tuples");
            Console.WriteLine();
            Console.WriteLine("Section 23.1: Accessing tuple elements");
            Console.WriteLine();
            var tuple = new Tuple<string, int, bool, object>("food", 123, true, new object());

            var item1 = tuple.Item1;
            var item2 = tuple.Item2;
            var item3 = tuple.Item3;
            var item4 = tuple.Item4;

            Console.WriteLine();
            Console.WriteLine("Section 23.2: Creating tuples");
            Console.WriteLine();
            var tuple1 = new Tuple<string, int, bool, object>("food", 123, true, new object());

            var tupleCreated = Tuple.Create("food", 123, true, new object());

            var newtuple = ("foo", 123, true, new object());

            (int number, bool flag, object myclass) tupple_new = (123, true, new object());

            Console.WriteLine();
            Console.WriteLine("Section 23.3: Comparing and sorting Tuples");
            List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            list.Add(new Tuple<int, string>(2, "foo"));
            list.Add(new Tuple<int, string>(1, "bar"));
            list.Add(new Tuple<int, string>(3, "qux"));

            list.Sort((a, b) => a.Item2.CompareTo(b.Item2));


            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            list.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            Console.WriteLine();
            Console.WriteLine("Section 23.4: Return multiple values from a method");
            var result = AddMultiply(25, 28);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);

        }

        static Tuple<int, int> AddMultiply(int a, int b)
        {
            return new Tuple<int, int>(a + b, a * b);
        }
    }
}