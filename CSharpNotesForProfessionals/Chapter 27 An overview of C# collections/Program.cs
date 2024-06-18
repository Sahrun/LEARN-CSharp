using System.Collections.Generic;

namespace Chapter_27_An_overview_of_C__collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter 27: An overview of C# collections");
            Console.WriteLine("Section 27.1: HashSet<T>");

            HashSet<int> validStoryPointValues = new HashSet<int>() { 1, 2, 3, 5, 8, 12, 21 };
            bool containsEight = validStoryPointValues.Contains(8);

            List<int> validStoryPointValues1 = new List<int> { 1, 2, 3, 5, 8, 13, 21 };

            bool containsEight1 = validStoryPointValues1.Contains(8);

            Console.WriteLine();
            Console.WriteLine("Section 27.2: Dictionary<TKey, TValue>");

            var people = new Dictionary<string, int>
            {
                { "Jhon", 30},{ "Mary", 35},{ "Jack", 40}
            };

            Console.WriteLine($"Age Jhon is: {people["Jhon"]}");
            //Console.WriteLine($"Age George is: {people["George"]}"); // Exception data not found
            int age;
            if (people.TryGetValue("Mary", out age))
            {
                Console.WriteLine($"Age Mary is :{age}");
            }

            people["Jhon"] = 40;
            //people.Add("Jhon", 40); // Throws ArgumentException since "John" already exists

            foreach (KeyValuePair<string, int> person in people)
            {
                Console.WriteLine("Name={0}, Age={1}", person.Key, person.Value);
            }

            foreach (string name in people.Keys)
            {
                Console.WriteLine("Name ={0}", name);
            }

            foreach (int _age in people.Values)
            {
                Console.WriteLine("Age={0}", _age);
            }

            //var peoples = new Dictionary<string, int>
            //{
            //    { "Jhon",38},{ "Mary",35},{ "Jack",40},{ "Jack",40}
            //};  // throws ArgumentException since "Jack" already exists

            Console.WriteLine();
            Console.WriteLine("Section 27.3: SortedSet<T>");

            var mySet = new SortedSet<int>();

            mySet.Add(2);
            mySet.Add(1);

            Console.WriteLine("Output:");
            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine();
            Console.WriteLine("Section 27.4: T[ ] (Array of T)");
            var myArray = new[] { "one", "two" };

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            myArray[0] = "something else";

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Section 27.5: List<T>");
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            list.Add(6);
            Console.WriteLine(list.Count);
            list.RemoveAt(3);
            Console.WriteLine(list.Count);
            Console.WriteLine(list[3]);

            Console.WriteLine();
            Console.WriteLine("Section 27.6: Stack<T>");
            var stack = new Stack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            var stack1 = new Stack<string>();
            stack1.Push("A");
            stack1.Push("B");
            stack1.Push("D");

            Console.WriteLine(stack1.Peek());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());

            Console.WriteLine();
            Console.WriteLine("Section 27.7: LinkedList<T>");
            var list1 = new LinkedList<int>();
            list1.AddLast(3);
            list1.AddLast(5);
            list1.AddLast(8);

            Console.WriteLine();
            Console.WriteLine("Section 27.8: Queue");
            var queue = new Queue<int>();

            queue.Enqueue(6);
            queue.Enqueue(4);
            queue.Enqueue(9);

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

        }
    }
}