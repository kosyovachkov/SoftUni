using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine(Math.Round(area, 3));
            }

            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(area, 3));
            }

            else if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideH = double.Parse(Console.ReadLine());
                double area = sideA * sideH / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
