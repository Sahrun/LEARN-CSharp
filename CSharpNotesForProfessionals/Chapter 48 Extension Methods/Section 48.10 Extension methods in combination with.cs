using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_10
{
    public interface IInterface
    {
        string Do();
    }


    public static class ExtensionMethods {
        public static string DoWhite(this IInterface obj)
        {
            return "DoWhite";
        }

        
    }

    public class Classy : IInterface { 
        public string Do()
        {
            return this.DoWhite();
        }
    }
}
