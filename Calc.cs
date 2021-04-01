using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistanceCalculation
{
    public static class Calc
    {
        public static double EulcDistance(Vector first, Vector second)
        => Math.Sqrt( Math.Pow((double)first.X - (double)second.X, 2) + Math.Pow((double)first.Y - (double)second.Y, 2) + +Math.Pow((double)first.Z - (double)second.Z, 2));

        public static void ClosestVec(List<Vector> VL)
        {
            Vector v1 = new Vector(0, 0, 0 );
            Vector v2 = new Vector(0, 0, 0 );
            int ind1 = 0;
            int ind2 = 0;
            double shortDist = 1000.0;


            Console.WriteLine("Scanning for two closest vectors in 3D array . . . \n");
            for(int i = 0; i < VL.Count - 1; i++)
            {
                for (int j = i + 1; j < VL.Count; j++)
                {
                    if (EulcDistance(VL[i], VL[j]) < shortDist)
                    {
                        v1 = VL[i];
                        v2 = VL[j];
                        shortDist = EulcDistance(VL[i], VL[j]);
                        ind1 = i;
                        ind2 = j;
                        Console.WriteLine($"New two closest points are: Point {i}: ({v1.X}, {v1.Y}, {v1.Z}) and Point {j}: ({v2.X}, {v2.Y}, {v2.Z}) with a distance of {shortDist}");
                    }
                }
            }

            Console.WriteLine($"\n\nThe two closest points are: Point {ind1}: ({v1.X}, {v1.Y}, {v1.Z}) and Point {ind2}: ({v2.X}, {v2.Y}, {v2.Z}) with a distance of {shortDist}");
        }
    }
}
