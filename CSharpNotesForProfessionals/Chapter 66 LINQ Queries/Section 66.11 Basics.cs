using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_11
    {
        internal Section_66_11()
        {
            var classroom = new Classroom
            {
                Students = new List<Student>{
                new Student { Name="Alice",Grade=97,HasSnack=true},
                new Student { Name = "Bob", Grade = 82, HasSnack = false },
                new Student { Name = "Jimmy", Grade = 71, HasSnack = true },
                new Student { Name = "Greg", Grade = 90, HasSnack = false },
                new Student { Name = "Joe", Grade = 59, HasSnack = false }

            }
            };

            classroom.Students.Where(s => s.Grade >= 90)
                .Select(s => s.Name);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public bool HasSnack { get; set; }
    }
    public class Classroom
    {
        public List<Student> Students { get; set; }
    }
}
