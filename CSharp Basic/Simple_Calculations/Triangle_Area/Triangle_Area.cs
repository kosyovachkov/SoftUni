using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Triangle_Area
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());

            double area = a * ha / 2;

            Console.WriteLine("Triangle area = {0}", Math.Round(area, 2));
        }
    }
}
