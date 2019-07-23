using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Rectangle : IArea
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Height * Width;
        }
    }
}
