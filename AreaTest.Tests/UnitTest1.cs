using System;
using Xunit;
using Area;

namespace AreaTest.Tests
{
    public class UnitTest1
    {
        IArea area;
        [Fact]
        public void TestSquare()
        {
            area = new Square(12);
            double actual = area.CalculateArea();
            Assert.Equal(144, actual);
        }
        [Fact]
        public void TestSquare2()
        {
            area = new Square(10.2);
            double actual = area.CalculateArea();
            Assert.Equal(104.04, actual,2);
        }
        [Fact]
        public void TestRectangle()
        {
            area = new Rectangle(12.44,10);
            double actual = area.CalculateArea();
            Assert.Equal(124.4, actual,1);
        }
        [Fact]
        public void TestCircle()
        {
            area = new Circle(15);
            double actual = area.CalculateArea();
            Assert.Equal(706.5, actual,1);
        }
        [Fact]
        public void TestTriangle()
        {
            area = new Triangle(12,14.65);
            double actual = area.CalculateArea();
            Assert.Equal(87.9, actual,1);
        }

    }
}
