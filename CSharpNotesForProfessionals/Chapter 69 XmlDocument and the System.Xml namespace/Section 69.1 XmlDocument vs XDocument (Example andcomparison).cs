using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Chapter_69_XmlDocument_and_the_System.Xml_namespace
{
    internal class Section_69_1
    {
        public Section_69_1()
        {
            // Load Document XML
            // - XmlDocument
            string filename = @"employees.xml";
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(filename);

            // - XDocument
            // XDocument xDocument = XDocument.Load(filename);

            // Create Document
            // - XmlDocument
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
            root.SetAttribute("name", "value");
            XmlElement child = doc.CreateElement("child");
            child.InnerText = "text node";
            root.AppendChild(child);
            doc.AppendChild(root);


            // - XDocument 
            XDocument xdoc = new XDocument(
                new XElement("Root", new XAttribute("name", "value"),
                new XElement("Child", "text node"))
                );

            // Change InnerText of node in XML
            // -  XmlDocument
            //XmlNode node = doc.SelectSingleNode("root");
            //node.InnerText = "value";

            // - XDocument
            //XElement rootNote = xdoc.XPathSelectElement("Root");
            //rootNote.Value = "value";

            // Save File after edit
            doc.Save(filename);

            //Retrieve Values from XML
            // - XmlDocument

            XmlNode node1 = doc.SelectSingleNode("root/child");
            string text = node1.InnerText;

            Console.WriteLine(text);

            // - Xdocument 
            XElement node2 = xdoc.XPathSelectElement("Root/Child");
            text = node2.Value;
            Console.WriteLine(text);


            // Retrieve value from all from all child elements where attribute = something.
            // - XmlDocument
            //List<string> valueList = new List<string>();
            //foreach (XmlNode n in nodelist)
            //{
            //    if (n.Attributes["type"].InnerText == "City")
            //    {
            //        valueList.Add(n.Attributes["type"].InnerText);

            //    }
            //}
            // - XDocument
            //var accounts = _doc.XPathSelectElements("/data/summary/account").Where(c =>
            //c.Attribute("type").Value == "setting").Select(c => c.Value);

            // Append a node
            // -XmlDocument
            //XmlNode nodeToAppend = doc.CreateElement("SecondLevelNode");
            //nodeToAppend.InnerText = "This title is created by code";
            ///* Append node to parent */
            //XmlNode firstNode = _doc.SelectSingleNode("xmlRootNode/levelOneChildNode");
            //firstNode.AppendChild(nodeToAppend);
            ///*After a change make sure to safe the document*/
            //_doc.Save(fileName);
            // -XDocument
            //_doc.XPathSelectElement("ServerManagerSettings/TcpSocket").Add(new XElement("SecondLevelNode"));
            ///*After a change make sure to safe the document*/
            //_doc.Save(fileName);





        }
    }
}
