using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double nn200 = 0;
            double nn399 = 0;
            double nn599 = 0;
            double nn799 = 0;
            double nn1000 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int chislo = int.Parse(Console.ReadLine());

                if (chislo < 200)
                {
                    nn200 += 1;
                }

                else if (chislo <=399)
                {
                    nn399 += 1;
                }

                else if (chislo <= 599)
                {
                    nn599 += 1;
                }

                else if (chislo <= 799)
                {
                    nn799 += 1;
                }

                else
                {
                    nn1000 += 1;
                }
            }

            double n200 = nn200 / numbers * 100;
            double n399 = nn399 / numbers * 100;
            double n599 = nn599 / numbers * 100;
            double n799 = nn799 / numbers * 100;
            double n1000 = nn1000 / numbers * 100;

            Console.WriteLine("{0:f2}%", n200);
            Console.WriteLine("{0:f2}%", n399);
            Console.WriteLine("{0:f2}%", n599);
            Console.WriteLine("{0:f2}%", n799);
            Console.WriteLine("{0:f2}%", n1000);
        }
    }
}
