using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_11
{
    internal abstract class Animal
    {
        string Name { get; set; }
        public abstract void MakeSound();
        public  abstract string Name1 {get;set;}
    }


    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meov meov");
        }
        public override string Name1 {get;set;}
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark bark");
        }
        public override string Name1 {get;set;}
    }


}
