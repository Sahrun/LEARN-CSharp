using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    public class Section_66_4
    {
        public Section_66_4()
        {
            var words = new[] { "a,b,c", "d,e", "f" };

            var splitWords = words.SelectMany(x => x.Split(',')).ToList();

            splitWords.ForEach(x => Console.WriteLine(x));


            //

            var schools = new[] {
                 new School(){ Students = new [] { new Student { Name="Bob"}, new Student { Name="Jack"} }},
                 new School(){ Students = new [] { new Student { Name="Jim"}, new Student { Name="John"} }}
            };

            var allStudent = schools.SelectMany(x => x.Students).ToList();
            allStudent.ForEach(x => Console.WriteLine(x.Name));
        }

        public class School
        {
            public Student[] Students { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
        }
    }

}