using Chapter_58_Inheritance_Section_58_3;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_58_Inheritance_Section_58_4
{
    public class LivingBeing
    {
        string Name { get; set; }
    }

    public interface IAnimal
    {
        bool HasHair { get; set; }
    }

    public class Cat : LivingBeing, IAnimal, INoiseMarker
    {
        public Cat()
        {
            Name = string.Empty;
            HasHair = false;
        }

        public bool HasHair { get; set; }
        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Nyan";
        }
    }


}

