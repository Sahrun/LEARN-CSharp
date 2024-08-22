using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_17
{
    public class Cake
    {
        public string Flavor { get; set; }
        public bool IsLie { get; set; }

        public Cake(string flavor, bool isLie)
        {
            Flavor = flavor;
            IsLie = isLie;
        }

        public void Display()
        {
            Console.WriteLine($"Cake Flavor: {Flavor}, Is it a lie? {IsLie}");
        }
    }
    //public static class CakeExtensions
    //{
    //    public static Cake EnsureTrueCake(this Cake cake)
    //    {
    //        //If the cake is a lie, substitute a cake from grandma, whose cakes aren't as tasty but are

    //        //known never to be lies. If the cake isn't a lie, don't do anything and return it.
    //        return CakeVerificationService.IsCakeLie(cake) ? GrandmasKitchen.Get1950sCake() : cake;
    //    }
    //}
}
