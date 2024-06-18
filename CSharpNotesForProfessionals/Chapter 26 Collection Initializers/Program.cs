namespace Chapter_26_Collection_Initializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 26: Collection Initializers");
            Console.WriteLine();
            Console.WriteLine("Section 26.1: Collection initializers");

            var stirngList = new List<string>
            {
              "foo",
              "bar",
            };

            var temp = new List<string>();
            temp.Add("foo");
            temp.Add("bar");
            var stringList = temp;

            var numberDictionary = new Dictionary<int, string> {
                {1,"One" },
                {2,"Two" }
            };

            var temp_dictionary = new Dictionary<int, string>();
            temp_dictionary.Add(1, "One");
            temp_dictionary.Add(2, "Two");

            var dictionary_list = temp_dictionary;

            Console.WriteLine();
            Console.WriteLine("Section 26.2: C# 6 Index Initializers");
            var dict = new Dictionary<string, int>
            {
                ["kay1"] = 1,
                ["key2"] = 50

            };

            var dict2 = new Dictionary<string, int>();

            dict2["key1"] = 1;
            dict2["key2"] = 50;

            var foo = new IndexableClass
            {
                [0] = 10,
                [1] = 20
            };

            Console.WriteLine();
            Console.WriteLine("Section 26.3: Collection initializers in custom classes");

            var col = new MyCollection {
            "foo",
                { "bar",3},
                "baz",
                123.45d
            };

            col.Add(123.9d);

            Console.WriteLine();
            Console.WriteLine("Section 26.4: Using collection initializer inside object initializer");

            Tag t = new Tag
            {
                Synonyms = new List<string> { "C#", "c-sharp" }
            };


            Tag1 t1 = new Tag1
            {
                Synonyms = { "C#", "c-sharp" }
            };

            var Tickets = new List<LotteryTicket>();
            //Tickets.Add(new LotteryTicket { "Mr Cool", 35663, 35732, 12312, 75685});
            //{
            //     {"Mr Cool" , 35663, 35732, 12312, 75685},
            //     {"Bruce" , 26874, 66677, 24546, 36483, 46768, 24632, 24527},
            //     {"John Cena", 25446, 83356, 65536, 23783, 24567, 89337}
            //};

        }
    }
}