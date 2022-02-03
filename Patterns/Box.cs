using System;
using System.Collections.Generic;
using System.Text;

namespace PatternHW
{
    public class Box
    {
        public double DrawerVolume { get; private set; }
     
        private Box(double volume)
        {
            DrawerVolume = volume;
        }

        public static Box Initialize(double volume)
        {
            if (volume <= 0)
            {
                throw new ArgumentException("Invalid size of shape!");
            }

            return new Box(volume);
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
