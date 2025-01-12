using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_17
    {
        public Section_66_17()
        {
            var item0 = new Foo();
            var item1 = new Foo();
            var item2 = new Bar();
            var item3 = new Bar();

            var collection = new IFoo[] { item0, item1, item2, item3 };

            // Using OfType
            Console.WriteLine("Using OfType");
            var foos = collection.OfType<Foo>();
            Print(foos);
            var bars = collection.OfType<Bar>();
            Print(bars);
            var foosAndBars = collection.OfType<IFoo>();
            Print(foosAndBars);

            // Using Where
            Console.WriteLine("Using Where");
            var foos1 = collection.Where(x => x is Foo);
            Print(foos1);
            var bar1 = collection.Where(x => x is Bar);
            Print(bar1);

            // Using Cast 
            Console.WriteLine("Using Cast");
            foos1 = collection.Cast<Foo>();
            //Print(foos1);
            bar1 = collection.Cast<Bar>();
         //   Print(bar1);
            foosAndBars = collection.Cast<IFoo>();
            Print(foosAndBars);

        }

        public void Print<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.GetType().Name);
                Console.Write(" ,");
            }
            Console.WriteLine();
        }
    }

    public interface IFoo { }
    public class Foo : IFoo { }
    public class Bar : IFoo { }

}
