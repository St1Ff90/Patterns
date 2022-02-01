using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Box
    {
        private double DrawerVolume;

        public Box(double volume)
        {
            DrawerVolume = volume;
        }

        public bool Add(Shape shape)
        {
            bool Result = false;

            if (DrawerVolume - shape.GetVolume() > 0)
            {
                Result = true;
                DrawerVolume = Math.Round(DrawerVolume, 2) - shape.GetVolume();
            }

            return Result;
        }
    }
}
