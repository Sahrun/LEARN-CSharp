using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_24
    {
        public Section_66_24()
        {
            PropertyInfo[] stringProps = typeof(string).GetProperties();//string properties
            PropertyInfo[] builderProps = typeof(StringBuilder).GetProperties();//stringbuilder properties

            var query = from s in stringProps
                        join b in builderProps
                        on new { s.Name, s.PropertyType } equals new { b.Name, b.PropertyType }
                        select new
                        {
                            s.Name,
                            s.PropertyType,
                            stringToken = s.MetadataToken,
                            stringBuilderToken = b.MetadataToken
                        };

            foreach (var prop in query)
            {
                Console.WriteLine($"Name = {prop.Name}");
                Console.WriteLine($"PropertyType = {prop.PropertyType}");
                Console.WriteLine($"stringToken = {prop.stringToken}");
                Console.WriteLine($"stringBuilderToken = {prop.stringBuilderToken}");
                Console.WriteLine("=============================================== ");
                Console.WriteLine();
            }
        }
    }
}
