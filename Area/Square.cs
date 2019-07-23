using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Square: IArea
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
