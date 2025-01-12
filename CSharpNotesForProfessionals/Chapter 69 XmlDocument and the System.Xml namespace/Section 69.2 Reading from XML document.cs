using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter_69_XmlDocument_and_the_System.Xml_namespace
{
    internal class Section_69_2
    {
        public Section_69_2()
        {
            string fullpath = @"Sample.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(fullpath);

            var oneValues = new List<string>();

            // Getting all XML nodes with tag name
            var accountNodes = xmldoc.GetElementsByTagName("Account");
            for (var i = 0; i < accountNodes.Count; i++)
            {
                // Use Xpath to find node
                var account = accountNodes[i].SelectSingleNode("./One");
                if (account != null && account.Attributes != null)
                {
                    // Read node attribute 
                    oneValues.Add(account.Attributes["number"].Value);
                }
            }

            Console.WriteLine(string.Join(",",oneValues));
        }
    }
}
