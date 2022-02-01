using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Pyramid : Shape
    {
        public double Height;
        public double NumberOfSides;
        public double SideLength;

        public Pyramid(double height, double numberOfSides, double sideLength)
        {
            Height = height;
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
            Volume = height * numberOfSides * (sideLength * sideLength) / (12 * Math.Tan(180 / numberOfSides));
        }
    }
}
