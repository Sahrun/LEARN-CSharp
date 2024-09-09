using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_23
{
    namespace StackOverflow
    {
        namespace Documentation
        {
            namespace CSharp.Keywords
            {
                public class Program
                {
                    public static void Main()
                    {
                        Console.WriteLine(typeof(Program).Namespace);
                        //StackOverflow.Documentation.CSharp.Keywords
                    }
                }
            }
        }
    }
    //namespace StackOverflow.Documentation.CSharp.Keywords
    //{
    //    public class Program
    //    {
    //        public static void Main()
    //        {
    //            Console.WriteLine(typeof(Program).Namespace);
    //            //StackOverflow.Documentation.CSharp.Keywords
    //        }
    //    }
    //}

}
