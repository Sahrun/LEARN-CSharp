using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_70_XDocument_and_the_System.Xml.Linq_namespace
{
    internal class Section_70_3
    {
        public Section_70_3()
        {
            string xmlFilePath = "D:\\LEARN\\LEARN CSharp\\CSharpNotesForProfessionals\\Chapter 70 XDocument and the System.Xml.Linq namespace\\fruit.xml";
            XDocument xdoc = XDocument.Load(xmlFilePath);
            XNamespace ns = "http://www.fruitauthority.fake";

            var elBanana = xdoc.Descendants()?.
             Elements(ns + "FruitName")?.
             Where(x => x.Value == "Banana")?.
             Ancestors(ns + "Fruit");

            var elColor = elBanana.Elements(ns + "FruitColor").FirstOrDefault();

            if (elColor != null)
            {
                elColor.Value = "Brown";
            }

            xdoc.Save(xmlFilePath);
        }
    }
}
