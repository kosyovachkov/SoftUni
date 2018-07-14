using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double countTwo = 0;
            double countThree = 0;
            double countFour = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    countTwo++;
                }

                if (num % 3 == 0)
                {
                    countThree++;
                }

               if (num % 4 == 0)
                {
                    countFour++;
                }
            }

            Console.WriteLine("{0:f2}%", countTwo / n * 100);
            Console.WriteLine("{0:f2}%", countThree / n * 100);
            Console.WriteLine("{0:f2}%", countFour / n * 100);
        }
    }
}
