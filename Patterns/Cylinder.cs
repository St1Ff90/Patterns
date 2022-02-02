using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Cylinder : Shape
    {
        public double Height { get; private set; }
        public double Radius { get; private set; }

        private Cylinder(double height, double radius)
        {
            Height = height;
            Radius = radius;
            Volume = 3.14 * radius * radius * height;
        }

        public static Cylinder Initialize(double height, double radius)
        {
            if (height <= 0 || radius <= 0)
            {
                throw new ArgumentException("Invalid size of shape!");
            }

            return new Cylinder(height, radius);
        }
    }
}
