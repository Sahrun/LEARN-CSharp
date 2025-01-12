using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter_69_XmlDocument_and_the_System.Xml_namespace
{
    internal class Section_69_3
    {
        public Section_69_3()
        {
            var xml = new XmlDocument();
            var root = xml.CreateElement("element");
            // Creates an attribute, so the element will now be "<element attribute='value' />"
            root.SetAttribute("attribute", "value");
            // All XML documents must have one, and only one, root element 
            xml.AppendChild(root);
            // Adding data to an XML document
            foreach (var dayOfWeek in Enum.GetNames((typeof(DayOfWeek))))
            {
                var day = xml.CreateElement("dayOfWeek");
                day.SetAttribute("name", dayOfWeek);
                // Don't forget to add the new value to the current document!
                root.AppendChild(day);
            }
            // Looking for data using XPath; BEWARE, this is case-sensitive
            var monday = xml.SelectSingleNode("//dayOfWeek[@name='Monday']");
            if (monday != null)
            {
                // Once you got a reference to a particular node, you can delete it
                // by navigating through its parent node and asking for removal
                monday.ParentNode.RemoveChild(monday);
            }

            // Displays the XML document in the screen; optionally can be saved to a file
            xml.Save(Console.Out);


        }
    }
}
