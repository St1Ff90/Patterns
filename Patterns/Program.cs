using PatternHW;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Pyramid(2, 3, 6),
                new Cylinder(10, 2),
                new Ball(4)
            };

            Box box = new Box(200);

            foreach (Shape item in shapes)
            {
                if (!box.Add(item))
                {
                    Console.WriteLine("Box is full!");
                } 
            }

        }
    }
}
