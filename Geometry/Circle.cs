using System;

namespace Geometry
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive");
            
            Radius = radius;
        }
        public override double Area => Math.PI * Radius * Radius;
    }
}