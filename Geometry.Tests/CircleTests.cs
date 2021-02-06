using System;
using Xunit;

namespace Geometry.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleConstructorThrowsArgumentExceptionWhenPassedNegativeOrZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-3.14));
        }

        [Theory]
        [InlineData(1 / Math.PI, 1 / Math.PI)]
        [InlineData(0.56418958354775628, 0.9999999999999999)]
        public void AreaPropertyReturnsCorrectResult(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            
            Assert.Equal(expectedArea, circle.Area);
        }
    }
}