using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                var c = first;
                first = second;
                second = c;
            }
            int point = int.Parse(Console.ReadLine());
            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            int pointDistFirst = Math.Abs(first - point);
            int pointDistSecond = Math.Abs(second - point);
            if (pointDistFirst < pointDistSecond)
            {
                Console.WriteLine(pointDistFirst);
            }
            else
            {
                Console.WriteLine(pointDistSecond);
            }
        }
    }
}