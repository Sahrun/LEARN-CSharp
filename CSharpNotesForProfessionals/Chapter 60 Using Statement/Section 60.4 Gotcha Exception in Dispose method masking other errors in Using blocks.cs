using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_4
{
    internal class ImplementDispose
    {
        internal ImplementDispose()
        {
            try
            {
                using (var disposable = new MyDisposable())
                {
                    throw new Exception("Couldn't perform operation.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    internal class MyDisposable : IDisposable
    {
        public void Dispose()
        {
            throw new Exception("Couldn't dispose successfully.");
        }
    }
}
