using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPointNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondPointNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Points firstPoint = new Points() { X = firstPointNumbers[0], Y = firstPointNumbers[1] };
            Points secondPoint = new Points() { X = secondPointNumbers[0], Y = secondPointNumbers[1] };

            double distance = Distance(firstPoint, secondPoint);

            Console.WriteLine("{0:f3}", distance);


        }


        public static double Distance(Points firstPoint, Points secondPoint)
        {
            int sideA = firstPoint.X - secondPoint.X;
            int sideB = firstPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }

    class Points
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
