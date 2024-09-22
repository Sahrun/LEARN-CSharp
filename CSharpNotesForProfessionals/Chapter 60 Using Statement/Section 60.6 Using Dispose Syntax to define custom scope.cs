using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_6
{
    public class CultureContext : IDisposable
    {
        private readonly CultureInfo originalculture;

        public CultureContext(string culture)
        {
            originalculture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        }

        public void Dispose()
        {
            Thread.CurrentThread.CurrentCulture = originalculture;
        }

    }

}