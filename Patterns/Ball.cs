using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Ball : Shape
    {
        public double Radius;

        public Ball(double radius)
        {
            Radius = radius;
            Volume = (4 / 3) * 3.14 * radius * radius * radius;
        }
    }
}
