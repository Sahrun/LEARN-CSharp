using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_70_XDocument_and_the_System.Xml.Linq_namespace
{
    internal class Section_70_2
    {
        public Section_70_2()
        {
            XNamespace xns = "http://www.fruitauthority.fake";
            XDocument xDoc =
             new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
             new XElement(xns + "FruitBasket",
             new XElement(xns + "Fruit",
             new XElement(xns + "FruitName", "Banana"),
             new XElement(xns + "FruitColor", "Yellow")),
             new XElement(xns + "Fruit",
             new XElement(xns + "FruitName", "Apple"),
             new XElement(xns + "FruitColor", "Red"))
             ));

            xDoc.Save(Console.Out);
        }
    }
}
