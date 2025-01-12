using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_67_LINQ_to_XML
{
    internal class Section_67_1
    {
        public Section_67_1()
        {
            XDocument xdocument = XDocument.Load("Employees.xml");
            IEnumerable<XElement> employees = xdocument.Root.Elements();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} has Employee ID {1}",
                  employee.Element("Name").Value,
                  employee.Element("EmpId").Value);
            }

            var names = from nm in xdocument.Root.Elements()
                        where (string)nm.Element("Sex") == "Female"
                        select nm;

            foreach (var name in names) 
                Console.WriteLine(name);
        }

//        XElement xelement = XElement.Load("..\\..\\Employees.xml");
//        var homePhone = from phoneno in xelement.Root.Elements("Employee")
//                        where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
//                        select phoneno;
        //        Console.WriteLine("List HomePhone Nos.");
        //foreach (XElement xEle in homePhone)
        //{
        // Console.WriteLine(xEle.Element("Phone").Value);
        //}

}
}
