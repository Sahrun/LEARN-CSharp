using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_45_Partial_class_and_methods_Section_45_1_Partial_classes
{
    public partial class PartialClass
    {
        public void ExampleMethod()
        {
            Console.WriteLine("Method call from the first declaration.");
        }
    }

    public partial class PartialClass
    {
        public void AnotherExampleMethod()
        {
            Console.WriteLine("Method call from the scond eclaration.");
        }
    }



}
