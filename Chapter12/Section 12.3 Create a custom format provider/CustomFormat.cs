using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12.Section_12._3_Create_a_custom_format_provider
{
    public class CustomFormat : IFormatProvider, ICustomFormatter
    {
        public string Format(string? format, object? arg, IFormatProvider? formatProvider)
        {
            if (!this.Equals(formatProvider))
                return null;

            if (format == "Reverse")
                return String.Join("", arg.ToString().Reverse());

            return arg.ToString();
        }

        public object? GetFormat(Type? formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : null;
        }
    }
}
