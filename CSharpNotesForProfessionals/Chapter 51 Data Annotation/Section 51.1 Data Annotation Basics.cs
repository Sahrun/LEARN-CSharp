using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_51_Data_Annotation_Section_51_1
{
    class Kid
    {
        [Range(0, 18)] // The age cannot be over 18 and cannot be negative
        public int Age { get; set; }
        [StringLength(maximumLength :50, MinimumLength = 3)] // The name cannot be under 3 chars or
      //  more than 50 chars
    public string Name { get; set; }
        [DataType(DataType.Date)] // The birthday will be displayed as a date only (without the time)
        public DateTime Birthday { get; set; }
    }

}
