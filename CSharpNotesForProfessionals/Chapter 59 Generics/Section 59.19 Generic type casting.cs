using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_59_Generics_Section_59_19
{
    /// <summary>
    /// Converts a data type to another data type.
    /// </summary>
    public static class Cast
    {
        public static T To<T>(object input, T defaultValue)
        {
            var result = defaultValue;

            try
            {
                if (input == null || input == DBNull.Value) return result;
                if (typeof(T).IsEnum)
                {
                    result = (T)Enum.ToObject(typeof(T), To(input, Convert.ToInt32(defaultValue)));
                }
                else
                {
                    result = (T)Convert.ChangeType(input, typeof(T));
                }
            }
            catch (Exception ex)
            {
                // Tracer.Current.LogException(ex);
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
        public static T To<T>(object input)
        {
            return To(input, default(T));
        }

    }
}
