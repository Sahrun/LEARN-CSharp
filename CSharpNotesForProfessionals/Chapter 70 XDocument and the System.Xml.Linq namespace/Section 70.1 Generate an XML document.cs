using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_70_XDocument_and_the_System.Xml.Linq_namespace
{
    internal class Section_70_1
    {
        public Section_70_1()
        {
            XNamespace xns = "http://www.fruittautority.fake";
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xDoc = new XDocument(xDeclaration);
            XElement xRoot = new XElement(xns + "FruitBasket");
            xDoc.Add(xRoot);

            XElement xelFruit1 = new XElement(xns + "Fruit");
            XAttribute idAttribute1 = new XAttribute("ID", "F0001");
            xelFruit1.Add(idAttribute1);
            XElement xelFruitName1 = new XElement(xns + "FruitName", "Banana");
            XElement xelFruitColor1 = new XElement(xns + "FruitColor", "Yellow");
            xelFruit1.Add(xelFruitName1);
            xelFruit1.Add(xelFruitColor1);
            xRoot.Add(xelFruit1);

            XElement xelFruit2 = new XElement(xns + "Fruit");
            XAttribute idAttribute2 = new XAttribute("ID", "F0002");
            xelFruit2.Add(idAttribute2);
            XElement xelFruitName2 = new XElement(xns + "FruitName", "Apple");
            XElement xelFruitColor2 = new XElement(xns + "FruitColor", "Red");
            xelFruit2.Add(xelFruitName2);
            xelFruit2.Add(xelFruitColor2);
            xRoot.Add(xelFruit2);

            xDoc.Save(Console.Out);
        }
    }
}
