using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionCircles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint(double[] input)
        {
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return point;
        }

        public static double DistanceBetweenTwoPoints(Point one, Point two)
        {
            double sideA = one.X - two.X;
            double sideB = one.Y - two.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public static Circle ReadCircle(Point point, double[] input)
        {
            Circle circle = new Circle();
            double radius = input[2];
            circle.Center = point;
            circle.Radius = radius;
            return circle;
        }

        public static void IntersectionCircle(Circle one, Circle two)
        {
            double r1 = one.Radius;
            double r2 = two.Radius;
            double distance = Point.DistanceBetweenTwoPoints(one.Center, two.Center);

            if (distance > r1 + r2)
            {
                Console.WriteLine("No");
            }

            else
            {
                Console.WriteLine("Yes");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] input1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] input2 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point one = Point.ReadPoint(input1);
            Point two = Point.ReadPoint(input2);

            Circle first = Circle.ReadCircle(one, input1);
            Circle second = Circle.ReadCircle(two, input2);

            Circle.IntersectionCircle(first, second);


        }

        

        


    }


}
