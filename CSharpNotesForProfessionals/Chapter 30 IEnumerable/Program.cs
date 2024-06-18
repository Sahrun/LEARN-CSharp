using System.Collections;

namespace Chapter_30_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 30: IEnumerable");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Section 30.1: IEnumerable with custom Enumerator");

            foreach (var coffe in new CoffeCollection())
            {
                Console.WriteLine($"Coffe : {coffe}");
            }

        }
    }

    public class CoffeCollection : IEnumerable
    {
        private CoffeeEnumerator enumerator;

        public CoffeCollection()
        {
            enumerator = new CoffeeEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }
    }

    public class CoffeeEnumerator : IEnumerator
    {
        string[] beverages = new string[3] { "espresso", "macchiato", "latte" };
        int currentIndex = -1;
        public object Current
        {
            get { return beverages[currentIndex]; }
        }

        public bool MoveNext()
        {
            currentIndex++;

            if (currentIndex < beverages.Length)
            {
                return true;
            }

            return false;
        }
        public void Reset()
        {
            currentIndex = 0;
        }
    }
}