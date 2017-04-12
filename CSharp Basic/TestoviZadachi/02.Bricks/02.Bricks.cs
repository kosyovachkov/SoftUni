using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBricks = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int maxAmount = int.Parse(Console.ReadLine());

            double course = numberOfWorkers * maxAmount;
            double neededCourses = Math.Ceiling(numberOfBricks / course);

            Console.WriteLine(neededCourses);

        }
    }
}
