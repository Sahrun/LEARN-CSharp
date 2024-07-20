using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_3_Interface_Basics
{
    public interface ICanDoThis
    {
        void TheThingCanDo();
        int SomeValueProperty { get; set; }
    }


    public class MyClass : ICanDoThis
    {
        public int SomeValueProperty { get; set; }
        public int SomeValueNotImplemtingAnything { get; set; }

        public void TheThingCanDo()
        {
            Console.WriteLine("method : TheThingCanDo");
        }
    }


}
