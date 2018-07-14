using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int monthDays = 0;
            int nextDays = d + 5;

            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                monthDays = 31;
            }

            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                monthDays = 30;
            }

            else
            {
                monthDays = 28;
            }

            if (nextDays <= monthDays)
            {
                Console.WriteLine("{0}.{1:00}", nextDays, m);

            }
            else
            {
                if (m == 12)
                {
                    Console.WriteLine("{0}.01", nextDays - monthDays);

                }
                else
                {
                    Console.WriteLine("{0}.{1:00}", nextDays - monthDays, m + 1);

                }
            }


        }
    }
}
