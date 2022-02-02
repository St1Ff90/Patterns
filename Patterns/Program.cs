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
                Pyramid.Initialize(2, 3, 6),
                Cylinder.Initialize(10, 2),
                Ball.Initialize(4)
            };

            Box box = Box.Initialize(200);

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
