using System;
using System.Collections.Generic;

namespace VectorDistanceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> VectorList = new List<Vector>();
            for(int i = 0; i < 100; i++)
            {
                VectorList.Add(new Vector());
            }
            Console.WriteLine("The Vectors in the system are: ");
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{VectorList[i].X} {VectorList[i].Y} {VectorList[i].Z}");
            }

            Calc.ClosestVec(VectorList);
        }
    }
}
