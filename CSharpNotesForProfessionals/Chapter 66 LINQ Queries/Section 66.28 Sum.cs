using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    public class Section_66_28
    {
        public Section_66_28()
        {
            int[] numbers = new int[] { 1, 4, 6 };

            Console.WriteLine(numbers.Sum());

            // var totalMonlySalary = employees.Sum(employee == employee.MonthlySalary);

            int?[] numbers1 = new int?[] { 1, null, 6 };

            Console.WriteLine(numbers1.Sum(num => num ?? 0));
        }
    }

}
