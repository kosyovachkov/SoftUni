using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            float eps = 0.000001f;

            if (Math.Abs(n1 - n2) >= eps)
            {
                Console.WriteLine("False");
            }

            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
