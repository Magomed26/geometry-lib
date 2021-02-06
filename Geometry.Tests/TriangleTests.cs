using System;
using Xunit;

namespace Geometry.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 1, 2)]
        [InlineData(3, -2, 5)]
        [InlineData(7, 1, -6)]
        [InlineData(10, 0, 5)]
        public void TriangleConstructorThrowArgumentExceptionWhenPassedNegativeValueOrZeroForSides(double a, double b, double c)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.Equal("Triangle's sides must be positive", exception.Message);
        }

        [Theory]
        [InlineData(1, 10, 12)]
        [InlineData(7, 10, 1)]
        [InlineData(3, 2, 5)]
        public void TriangleConstructorThrowArgumentExceptionWhenTriangleIsInvalid(double a, double b, double c)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.Equal("Triangle is not valid", exception.Message);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(4, 5, 3, true)]
        [InlineData(3, 4, 6, false)]
        public void IsRightAngledPropertyReturnsCorrectResult(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            
            Assert.Equal(expected, triangle.IsRightAngled);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(9, 10, 17, 36)]
        public void AreaPropertyReturnsCorrectResult(double a, double b, double c, double expectedArea)
        {
            var triangle = new Triangle(a, b, c);
            
            Assert.Equal(expectedArea, triangle.Area);
        }
    }
}