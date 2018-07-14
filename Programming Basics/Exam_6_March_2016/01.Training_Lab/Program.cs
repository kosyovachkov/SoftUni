using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            h = h * 100;
            w = w * 100;

            double rows = Math.Truncate(h / 120);
            double desks = Math.Truncate((w - 100) / 70);

            double allDesks = rows * desks - 3;

            Console.WriteLine(allDesks);

        }
    }
}
