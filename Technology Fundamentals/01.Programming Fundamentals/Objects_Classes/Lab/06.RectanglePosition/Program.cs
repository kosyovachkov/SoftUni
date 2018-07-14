using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Rectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] rec1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rec2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle one = new Rectangle() { left = rec1[0], top = rec1[1], width = rec1[2], heigth = rec1[3]};
            Rectangle two = new Rectangle() { left = rec2[0], top = rec2[1], width = rec2[2], heigth = rec2[3] };

            IsInside(one, two);

        }

        private static void IsInside(Rectangle one, Rectangle two)
        {
            if (one.left>=two.left&&(one.left+one.width)<=(two.left+two.width)&&one.top>=two.top&&(one.top+one.heigth<=two.top+two.heigth))
            {
                Console.WriteLine("Inside");
            }

            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }

    
}
