using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_5_Implementing_multiple_interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
    }

    public interface INoiseMaker
    {
        string MakeNoise();
    }

    public class Cat : IAnimal, INoiseMaker {
        public Cat() {
            Name = "Cat";
        }

        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Nyan";
        }
    }
}
