using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_45_Partial_class_and_methods
{
    public partial class PartialClass_3 // Auto-generated
    {
        partial void PartialMethod();
    }
    public partial class PartialClass_3 // Human-written
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial method called.");
        }

        public void ExportMethod() {
            PartialMethod();
        }
    }

}
