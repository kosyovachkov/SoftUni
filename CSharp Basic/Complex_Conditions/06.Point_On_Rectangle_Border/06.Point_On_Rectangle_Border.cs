using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_On_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            if (x1 == x && y1 <= y && y <= y2 || 
                x2 == x && y1 <= y && y <= y2 || 
                y1 == y && x1 <= x && x <= x2 || 
                y2 == y && x1 <= x && x <= x2)
            {
                Console.WriteLine("Border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
