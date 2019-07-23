using System;
using System.Linq;
using Xunit;
using Area;

namespace Area.Tests
{
   
    public class UnitTest1
    {
        IArea area;
        [Fact]
        public void TestSquare()
        {
            area = new Square(12);
            double actual=area.CalculateArea();
            Assert.Equal(144, actual,0);
        }
    }
}
