using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Triangle: IArea
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * Height * Width;
        }
    }
}
