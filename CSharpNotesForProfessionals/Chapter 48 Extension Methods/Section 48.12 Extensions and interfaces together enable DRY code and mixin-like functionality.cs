using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_12
{
    public interface ITimeFormatter
    {
        string Format(TimeSpan span);
    }

    public static class TimeFormatter
    {
        // Provide an overload to *all* implementers of iTimeFormatter.
        public static  string Format(
            this ITimeFormatter formatter,
            int millisecondsSpan)
            => formatter.Format(TimeSpan.FromMilliseconds(millisecondsSpan));


    }

    public class SecondsTimeFormatter : ITimeFormatter
    {
        public string Format(TimeSpan span)
        {
            return $"{(int)span.TotalMilliseconds}";
        }
    }

}
