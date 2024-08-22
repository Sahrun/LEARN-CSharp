using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_9
{
    public interface IVehicle
    {
        int MilesDriven {  get; set; }
    }

    public static class Extensions {
        public static int FeetDriven(this IVehicle vehicle)
        {
            return vehicle.MilesDriven * 5028;
        }
    }
}
