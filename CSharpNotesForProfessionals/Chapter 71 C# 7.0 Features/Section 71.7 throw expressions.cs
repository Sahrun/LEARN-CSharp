using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    internal class Section_71_7
    {
        public Section_71_7()
        {
            var spoons = "dinner,desert,soup".Split(',');
            var spoonsArray = spoons.Length > 0 ? spoons : null;
            if (spoonsArray == null)
            {
                throw new Exception("There are no spoons");
            }

            var spoonsArray1 = spoons.Length > 0
             ? spoons
             : new Func<string[]>(() =>
             {
                 throw new Exception("There are no spoons");
             })();

            var spoonsArray2 = spoons.Length > 0 ? spoons : throw new Exception("There are no spoons");

            spoons = "dinner,desert,soup".Split(',');
            spoonsArray = spoons.Length > 0 ? spoons : null;
            if (spoonsArray == null)
            {
                throw new Exception("There are no spoons");
            }

            spoonsArray = spoons.Length > 0
            ? spoons
            : new Func<string[]>(() =>
            {
                throw new Exception("There are no spoons");
            })();

            spoonsArray = spoons.Length > 0 ? spoons : throw new Exception("There are no spoons");
        }
    }

    class Person3
    {
        public string Name { get; }
        public Person3(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));
        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
        }
        public string GetLastName() => throw new NotImplementedException();
    }

    //class Person4
    //{
    //    private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int,
    //   string>();
    //    private int id = GetId();
    //    public Person4(string name) => names.TryAdd(id, name); // constructors
    //    ~Person4() => names.TryRemove(id, out _); // finalizers
    //    public string Name
    //    {
    //        get => names[id]; // getters
    //        set => names[id] = value; // setters
    //    }
    //}


}
