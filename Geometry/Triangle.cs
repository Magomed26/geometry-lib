using System;

namespace Geometry
{
    public class Triangle : Shape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public bool IsRightAngled => Math.Abs(A * A - (B * B + C * C)) < 0.1 || 
                                     Math.Abs(B * B - (A * A + C * C)) < 0.1 ||
                                     Math.Abs(C * C - (A * A + B * B)) < 0.1;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Triangle's sides must be positive");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Triangle is not valid");
            
            A = a;
            B = b;
            C = c;
        }
        public override double Area => GetArea();

        private double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}