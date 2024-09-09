using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_13
{
    internal class MyClass
    {

    }
    internal class Section_52_13
    {

        internal Section_52_13()
        {
            Debug.Assert(default(MyClass) == null);
            Debug.Assert(default(string) == null);

            var defaultStruct = default(MyStruct);
            Debug.Assert(defaultStruct.Equals(new MyStruct()));
            Debug.Assert(defaultStruct.Location.Equals(new Coordinates()));
            Debug.Assert(defaultStruct.Location.X == 0);
            Debug.Assert(defaultStruct.Location.Y == 0);
            Debug.Assert(defaultStruct.SecondLocation == null);
            Debug.Assert(defaultStruct.Name == null);
            Debug.Assert(defaultStruct.Duration == TimeSpan.Zero);

        }

        //public T GetResourceOrDefault<T>(string resourceName)
        //{
        //    if (ResourceExists(resourceName))
        //    {
        //        return (T)GetResource(resourceName);
        //    }
        //    else
        //    {
        //        return default(T);
        //    }
        //}



    }

    struct Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct MyStruct
    {
        public string Name { get; set; }
        public Coordinates Location { get; set; }
        public Coordinates? SecondLocation { get; set; }
        public TimeSpan Duration { get; set; }
    }




}
