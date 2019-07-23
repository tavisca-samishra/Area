using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Circle: IArea
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
