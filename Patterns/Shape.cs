using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Shape
    {
        protected double Volume;

        public double GetVolume()
        {
            return Math.Round(Volume, 2);
        }
    }
}
