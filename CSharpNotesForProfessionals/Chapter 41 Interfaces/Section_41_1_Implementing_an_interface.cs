using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section41_1_Implementing_an_interface
{
    public interface InoiseMaker
    {
        string MakeNoise();
    }

    public class Cat : InoiseMaker
    {
        public string MakeNoise()
        {
            return "Nyan";
        }
    }

    public class Dog : InoiseMaker
    {
        public string MakeNoise()
        {
            return "Woof";
        }
    }
}


