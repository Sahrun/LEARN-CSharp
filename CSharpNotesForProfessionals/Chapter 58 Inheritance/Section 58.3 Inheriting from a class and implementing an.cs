using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_58_Inheritance_Section_58_3
{
    internal class Animal
    {
        public string Name { get; set; }
    }

    internal interface INoiseMarker
    {
        string MakeNoise();
    }


    internal class Cat : Animal, INoiseMarker
    {
        internal Cat()
        {
            Name = "Cat";
        }
        public string MakeNoise()
        {
            return "Nyan";
        }
    }
}
