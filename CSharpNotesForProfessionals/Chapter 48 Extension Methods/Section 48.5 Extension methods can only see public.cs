using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_5
{
    public class SomeClass
    {
        public void DoStuff() { 
        
        }

        protected void DoMegic()
        {
            
        }


        
    }

    public static class SomeClassExtensions
    {
        public static void DoStuffWrapper(this SomeClass someInstance)
        {
            someInstance.DoStuff();
        }

        public static void DoMagicWrapper(this SomeClass someInstance)
        {
            // someInstance.DoMegic();  // compilation error
        }
    }
}
