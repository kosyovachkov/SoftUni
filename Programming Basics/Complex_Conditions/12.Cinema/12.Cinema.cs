using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double profit = 1;

            if (type == "premiere")
            {
                profit = rows * columns * 12;
            }

            else if (type == "normal")
            {
                profit = rows * columns * 7.5;
            }

            else
            {
                profit = rows * columns * 5;
            }

            Console.WriteLine("{0:F2} leva", profit);
        }
    }
}
