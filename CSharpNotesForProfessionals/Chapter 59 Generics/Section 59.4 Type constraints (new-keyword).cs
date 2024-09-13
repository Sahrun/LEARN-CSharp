using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_59_Generics_Section_59_4
{
    public class Foo
    {
        public Foo() { }
    }

    public class Bar
    {
        public Bar(string a)
        {
        }
        //public Bar() { }
    }


    public class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
