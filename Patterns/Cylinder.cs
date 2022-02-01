using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Cylinder : Shape
    {
        public double Height;
        public double Radius;

        public Cylinder(double height, double radius)
        {
            Height = height;
            Radius = radius;
            Volume = 3.14 * radius * radius * height;
        }
    }
}
