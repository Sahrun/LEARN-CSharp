using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_38
{
    internal class Section_52_38
    {
        public Section_52_38() {
            CatchException(Method1);
            CatchException(Method2);
        }
        private void CatchException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex) when (ex.Message.Contains("when"))
            {

                Console.WriteLine("Caught an exception with when");
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Caught an exception without when");
            }

        }

        private void Method1() { throw new Exception("message for exception with when"); }
        private void Method2() { throw new Exception("message for general exception"); }
    }
}
