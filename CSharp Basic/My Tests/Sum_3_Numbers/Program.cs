using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            int minValue = Math.Min(a, Math.Min(b, c));
            int maxValue = Math.Max(a, Math.Max(b, c));
            int midValue = a + b + c - minValue - maxValue;

            if (minValue+midValue==maxValue)
            {
                Console.WriteLine("{0} + {1} + {2}", minValue, midValue, maxValue );
            }

            else
            {
                Console.WriteLine("No");
            }



            // if (a + b == c)
            // {
            //     Console.WriteLine(a + " + " + b + " = " + (a + b));
            // }

            //else if (a + c == b)
            // {
            //     Console.WriteLine(c + " + " + a + " = " + (a + c));
            // }

            // else if (b + c == a)
            // {
            //     Console.WriteLine(b + " + " + c + " = " + (b + c));
            // }

            // else
            // {
            //     Console.WriteLine("No");
            // }
        }
    }
}
