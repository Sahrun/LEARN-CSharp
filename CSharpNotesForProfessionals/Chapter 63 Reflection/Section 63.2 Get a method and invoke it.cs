using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection_Section_63_2
{
    public class Program1
    {
        public Program1()
        {

            var theString = "hello";
            var method = theString.GetType()
                        .GetMethod("Substring",
                        new[] { typeof(int), typeof(int) });

            var result = method.Invoke(theString, new object[] { 0, 4 });
            Console.WriteLine(result);


            var method2 = typeof(Math).GetMethod("Exp");
            var resut1 = method2.Invoke(null, new object[] { 2 });

            Console.WriteLine(resut1);
        }
    }
}
