using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Ball : Shape
    {
        public double Radius { get; private set; }

        private Ball(double radius)
        {
            Radius = radius;
            Volume = (4 / 3) * 3.14 * radius * radius * radius;
        }

        public static Ball Initialize(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Invalid size of shape!");
            }

            return new Ball(radius);
        }
    }
}

