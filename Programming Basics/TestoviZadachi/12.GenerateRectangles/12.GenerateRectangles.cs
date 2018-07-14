using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            bool areaIsSmaller = true;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var wight = right - left;
                            var heght = bottom - top;
                            var area = wight * heght;

                            if (m <= area)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                areaIsSmaller = false;
                            }


                        }
                    }
                }
            }

            if (areaIsSmaller)
            {
                Console.WriteLine("No");
            }
        }
    }
}
