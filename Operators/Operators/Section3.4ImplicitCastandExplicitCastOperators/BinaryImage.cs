using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section3._4ImplicitCastandExplicitCastOperators
{
    public class BinaryImage
    {
        private bool[] _pixels;

        public static implicit operator ColorImage(BinaryImage im)
        {
            return new ColorImage(im);
        }

        public static explicit operator bool[](BinaryImage im)
        {
            return im._pixels;
        }

        //public static explicit operator ColorImage(BinaryImage im)
        //{
        //    return new ColorImage(im);
        //}

    }
}
