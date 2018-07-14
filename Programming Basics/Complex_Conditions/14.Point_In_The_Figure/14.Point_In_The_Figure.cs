using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && x < (3 * h) && y > 0 && y < h || 
                x > h && x < (2 * h) && y > h && y < (4 * h) ||
                x > h && x < (2 * h) && y > 0 && y <= h)
            {
                Console.WriteLine("inside");
            }

            else if (x == 0 && y >= 0 && y <= h || 
                x == (3 * h) && y >= 0 && y <= h || 
                x == h && y >= h && y <= (4 * h) || 
                x == (2 * h) && y >= h && y <= (4 * h) || 
                y == 0 && x >= 0 && x <= (3 *h) ||
                y == h && x >= 0 && x <= h ||
                y == h && x >= (2 * h) && x <= (3 * h) ||
                y == (4 * h) && x >= h && x <= (2 * h))
            {
                Console.WriteLine("border");
            }

            else
            {
                Console.WriteLine("outside");
            }


            // Tova e drugo moe reshenie

            //int number = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //int x1 = 0;
            //int y1 = number;
            //int x2 = (3 * number);
            //int y2 = 0;

            //int x3 = number;
            //int y3 = (4 * number);
            //int x4 = (2 * number);
            //int y4 = number;

            //if (x > x1 && x < x2 && y > y2 && y < y1 && y > y2 ||
            //    x > x3 && x < x4 && y > y4 && y < y3 ||
            //    y == y4 && x > x3 && x < x4)
            //{
            //    Console.WriteLine("inside");
            //}

            //else if ((x == x1 || x == x2) && y >= y2 && y <= y1 ||
            //         (x == x3 || x == x4) && y >= y4 && y <= y3 ||
            //             (y == y1 || y == y2) && x >= x1 && x <= x2 ||
            //             (y == y3 || y == y4) && x >= x3 && x <= x4)
            //{
            //    Console.WriteLine("border");
            //}

            //else
            //{
            //    Console.WriteLine("outside");
            //}

        }
    }
}
