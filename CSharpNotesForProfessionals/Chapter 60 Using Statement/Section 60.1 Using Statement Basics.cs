using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_1
{
    internal class StatementBasics
    {
        internal int Foo() {
            var fileName = "file.text";
            {
                FileStream disposible = null;
                try
                {
                    disposible = File.Open(fileName, FileMode.Open);

                    return disposible.ReadByte();

                }
                finally
                {
                    if (disposible != null) disposible.Dispose();
                }
            }
        }

        internal int Foo2() {
            var filename = "file.text";
            using (var disposible = File.Open(filename, FileMode.Open))
            {
                return disposible.ReadByte();
            }
        }

        internal int Foo3()
        {
            var fileName = "file.text";
            using(var disposible = File.Open(fileName, FileMode.Open))
            {
                throw new NotImplementedException();
            }
        }
    }
}
