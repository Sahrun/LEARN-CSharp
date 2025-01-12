using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    public class Geometry { }
    class Triangle : Geometry
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Base { get; set; }
    }
    class Rectangle : Geometry
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    class Square : Geometry
    {
        public int Width { get; set; }
    }

    internal class Section_71_4
    {
        public Section_71_4()
        {
            Geometry g = new Square { Width = 5 };
            switch (g)
            {
                case Triangle t:
                    Console.WriteLine($"{t.Width} {t.Height} {t.Base}");
                    break;
                case Rectangle sq when sq.Width == sq.Height:
                    Console.WriteLine($"Square rectangle: {sq.Width} {sq.Height}");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Width} {r.Height}");
                    break;
                case Square s:
                    Console.WriteLine($"{s.Width}");
                    break;
                default:
                    Console.WriteLine("<other>");
                    break;
            }

            string o="";
            string s1 = o as string;
            if (s1 != null)
            {
                // do something with s
            }


            if (o is string s2)
            {
                //Do something with s
            };

            if (true)
            {
                if (o is string s3)
                {
                    //Do something with s
                }
                else
                {
                    // s is unassigned here, but accessible
                }
                // s is unassigned here, but accessible
            }
            // s is not accessible here
        }
    }
}
