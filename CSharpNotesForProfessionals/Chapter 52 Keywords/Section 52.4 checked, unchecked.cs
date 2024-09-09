using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_4
{
    internal class CheckedUnchecked
    {

        internal byte Checksum(byte[] data)
        {
            byte result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                result = unchecked((byte)((int)result + (int)data[i])); // unchecked expression
            }
            return result;
        }

        internal int intUnchecked()
        {
            int result = 0;
            int maxInt = int.MaxValue;

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    result = unchecked(maxInt + 1);
                }
            }
            catch (OverflowException evEx)
            {
                Console.WriteLine(evEx.Message);
            }

            return result;
        }

        internal int intChecked()
        {
            int result = 0;
            int maxInt = int.MaxValue;

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    result = unchecked(maxInt + 1);
                }
            }
            catch (OverflowException evEx)
            {
                Console.WriteLine(evEx.Message);
            }

            return result;
        }

    }
}
