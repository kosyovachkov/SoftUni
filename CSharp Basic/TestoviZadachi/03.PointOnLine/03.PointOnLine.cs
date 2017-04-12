using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int distanceOne = Math.Abs(point - first);
            int distanceTwo = Math.Abs(point - second);

            int minDistance = Math.Min(distanceOne, distanceTwo);

            if (first > second)
            {
                int mid = first;
                first = second;
                second = mid;

            }

            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
                Console.WriteLine(minDistance);

            }

            else
            {
                Console.WriteLine("out");
                Console.WriteLine(minDistance);
            }
        }
    }
}
