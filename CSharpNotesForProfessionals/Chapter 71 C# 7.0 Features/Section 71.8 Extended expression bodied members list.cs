using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    class Section_71_8
    {
        public Section_71_8()
        {

        }
    }

    class Person4
    {
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int,
       string>();
        private int id = GetId();
        public Person4(string name) => names.TryAdd(id, name); // constructors
        ~Person4() => names.TryRemove(id, out _); // finalizers
        public string Name
        {
            get => names[id]; // getters
            set => names[id] = value; // setters
        }

        private static int GetId()
        {

            return 1;

        }
    }

}
