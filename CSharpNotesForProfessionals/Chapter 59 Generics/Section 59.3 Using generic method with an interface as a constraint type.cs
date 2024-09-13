using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_59_Generics_Section_59_3
{
    public interface IFood
    {
        void EatenBy(Animal animal);
    }

    public class Grass : IFood
    {
        public void EatenBy(Animal animal)
        {
            Console.WriteLine("Grass was eaten by: {0}", animal.Name);
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public void Eat<TFood>(TFood food) where TFood : IFood
        {
            food.EatenBy(this);
        }
    }

    public class Carnivore : Animal
    {

        public Carnivore()
        {
            Name = "Carnivora";
        }


    }

    public class Herbivore : Animal, IFood
    {
        public Herbivore()
        {
            Name = "Herbivore";
        }

        public void EatenBy(Animal animal)
        {
            Console.WriteLine("herbivore was eaten by: {0}", animal.Name);
        }
    }






}
