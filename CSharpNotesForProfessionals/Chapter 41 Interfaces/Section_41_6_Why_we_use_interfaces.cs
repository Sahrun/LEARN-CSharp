using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_6_Why_we_use_interfaces
{
    public interface IShape
    {
        double ComputeArea();
    }

    public class Rectangle : IShape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double ComputeArea()
        {
            return length * width;
        }
    }

    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double ComputeArea()
        {
            return Math.Pow(radius, 2.0) * Math.PI;
        }
    }
}
