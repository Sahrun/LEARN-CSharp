using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_45_Partial_class_and_methods
{


    public class BaseClass
    {
        public void MedhodClassBase()
        {

        }
    }

    public class BaseClass1
    {
        
    }

    public partial class PartialClass_1 : BaseClass
    {
        public void Test() {
            MedhodClassBase();
        }
     
    }

    public partial class PartialClass_1  
    {
        public void Test1() {
            MedhodClassBase();
        }
    }
}
