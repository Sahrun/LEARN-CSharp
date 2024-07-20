using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_4_IComparable_T_as_an_Example_of_Implementing
{
    public class Item : IComparable<Item>
    {
        public string name { private get; set; }
        public int idNumber { private get; set; }
        public decimal price { private get; set; }
        public int CompareTo(Item? other)
        {
            return (this.idNumber - other.idNumber);
        }
    }

}

