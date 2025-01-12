using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    internal class Section_71_6
    {
        public Section_71_6()
        {
            // Using a binary literal:
            // bits: 76543210
            int a1 = 0b00100010; // binary: explicitly specify bits
                                 // Existing methods:
            int a2 = 0x22; // hexadecimal: every digit corresponds to 4 bits
            int a3 = 34; // decimal: hard to visualise which bits are set
            int a4 = (1 << 5) | (1 << 1); // bitwise arithmetic: combining non-zero bits

            Console.WriteLine(a1);

            Console.WriteLine("Flags enumerations");
            
        }
    }

    [Flags]
    public enum DaysOfWeek
    {
        // Previously available methods:
        // decimal hex bit shifting
        Monday = 1, // = 0x01 = 1 << 0
        Tuesday = 2, // = 0x02 = 1 << 1
        Wednesday = 4, // = 0x04 = 1 << 2
        Thursday = 8, // = 0x08 = 1 << 3
        Friday = 16, // = 0x10 = 1 << 4
        Saturday = 32, // = 0x20 = 1 << 5
        Sunday = 64, // = 0x40 = 1 << 6
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        Weekends = Saturday | Sunday
    }

    [Flags]
    public enum DaysOfWeek1
    {
        Monday = 0b00000001,
        Tuesday = 0b00000010,
        Wednesday = 0b00000100,
        Thursday = 0b00001000,
        Friday = 0b00010000,
        Saturday = 0b00100000,
        Sunday = 0b01000000,
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        Weekends = Saturday | Sunday
    }

}
