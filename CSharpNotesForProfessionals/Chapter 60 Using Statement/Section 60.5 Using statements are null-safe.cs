using Ninject.Infrastructure.Disposal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_5
{
    internal class NullSafe
    {
        public NullSafe()
        {

            using (var disposible = TryOpenFile())
            {
                Console.WriteLine("Test pembuktian");

                //disposible.Dispose(true);
                if (disposible != null)
                {
                    disposible.Dispose();
                }
            }
        }
        DisposableObject TryOpenFile()
        {
            return null;
        }
    }

}
