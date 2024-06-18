using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7.Section7._1Basicusage
{
    public class Basicusage
    {
        public Basicusage()
        {
            string testString = null;
            Console.WriteLine("The spesified string is = " + (testString ?? "not provided"));
        }
    }
}
