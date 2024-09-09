using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_6
{
    internal class Section_52_6
    {
        internal Section_52_6()
        {

            //unsafe
            //{ 
            //byte* ptr = stackalloc byte[1024];
            //}

            //Allocate 1 byte
            unsafe
            {
                byte* ptr = stackalloc byte[1];

                //Unpredictable results...
                ptr[10] = 1;
                ptr[-1] = 2;
            }

          
        }
    }
}
