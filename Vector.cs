using System;
using System.Collections.Generic;
using System.Text;
//using VectorDistanceCalculation.Point;

namespace VectorDistanceCalculation
{
    public class Vector
    {
        static Random rando = new Random();
        public int X { get; }
        public int Y { get; }

        public int Z { get; }

        public Vector()
        {
            X = rando.Next(1, 1001);
            Y = rando.Next(1, 1001);
            Z = rando.Next(1, 1001);
        }
        public Vector(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = Z;
        }
    }
}
