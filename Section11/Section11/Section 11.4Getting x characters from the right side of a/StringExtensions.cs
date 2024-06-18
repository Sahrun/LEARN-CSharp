using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Section_11._4Getting_x_characters_from_the_right_side_of_a
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get left charakter string
        /// </summary>
        /// <param name="stirngparam"></param>
        /// <param name="numchars"></param>
        /// <returns></returns>
        public static string Left(this string stringparam, int numchars)
        {
            stringparam += string.Empty;

            numchars = Math.Abs(numchars);

            if (numchars > stringparam.Length)
                numchars = stringparam.Length;

            return stringparam.Substring(0, numchars);
        }

        /// <summary>
        /// Get right charakter string
        /// </summary>
        /// <param name="stringparam"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string Right(this string stringparam, int numbers)
        {
            stringparam += string.Empty;
            numbers = Math.Abs(numbers);

            if (numbers > stringparam.Length)
                numbers = stringparam.Length;

            return stringparam.Substring(stringparam.Length - numbers);
        }
        /// <summary>
        /// Get mind charakter string start
        /// </summary>
        /// <param name="stringparam"></param>
        /// <param name="startindex"></param>
        /// <returns></returns>
        public static string Mid(this string stringparam, int startindex)
        {
            stringparam += string.Empty;

            startindex = Math.Abs(startindex);

            if (startindex > stringparam.Length)
                startindex = stringparam.Length;

            return stringparam.Substring(startindex);
        }

        /// <summary>
        /// Get mind charakter string start and leng
        /// </summary>
        /// <param name="stringparam"></param>
        /// <param name="startindex"></param>
        /// <param name="numchars"></param>
        /// <returns></returns>
        public static string Mid(this string stringparam, int startindex, int numchars)
        {
            stringparam += string.Empty;

            startindex = Math.Abs(startindex);

            numchars = Math.Abs(numchars);

            if (startindex > stringparam.Length)
                startindex = stringparam.Length;

            return stringparam.Substring(startindex - 1, numchars);
        }
    }
}
