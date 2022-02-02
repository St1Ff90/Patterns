using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Pyramid : Shape
    {
        public double Height { get; private set; }
        public double NumberOfSides { get; private set; }
        public double SideLength { get; private set; }

        private Pyramid(double height, int numberOfSides, double sideLength)
        {
            Height = height;
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
            Volume = height * numberOfSides * (sideLength * sideLength) / (12 * Math.Tan(180 / numberOfSides));
        }

        public static Pyramid Initialize(double height, int numberOfSides, double sideLength)
        {
            if (height <= 0 || numberOfSides <= 0 || sideLength <= 0)
            {
                throw new ArgumentException("Invalid size of shape!");
            }

            return new Pyramid(height, numberOfSides, sideLength);
        }
    }
}
