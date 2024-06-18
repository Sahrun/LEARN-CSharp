using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Section3._4ImplicitCastandExplicitCastOperators
{
    public class ColorImage
    {
        private BinaryImage _binaryImage;


        public ColorImage(BinaryImage binaryImage)
        {
            _binaryImage = binaryImage;
        }

        public void Display()
        {
            Console.WriteLine("Displaying Color Image");
        }

    }
}
