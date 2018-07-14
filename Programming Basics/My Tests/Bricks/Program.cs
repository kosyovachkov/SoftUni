using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            double bricks = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());

            double courses = bricks / (workers * volume);
            

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
