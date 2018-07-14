using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Points
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Points[] pointsPair = new Points[n];

            for (int i = 0; i < n; i++)
            {
                int[] pointData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Points point = new Points() { X = pointData[0], Y = pointData[1] };
                pointsPair[i] = point;

            }

            double minDistance = double.MaxValue;
            Points pointOne = new Points();
            Points pointTwo = new Points();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double distance = Distance(pointsPair[i], pointsPair[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        pointOne = pointsPair[i];
                        pointTwo = pointsPair[j];
                    }
                }


            }

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0}, {1})", pointOne.X, pointOne.Y);
            Console.WriteLine("({0}, {1})", pointTwo.X, pointTwo.Y);
        }


        public static double Distance(Points firstPoint, Points secondPoint)
        {
            int sideA = firstPoint.X - secondPoint.X;
            int sideB = firstPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
}

