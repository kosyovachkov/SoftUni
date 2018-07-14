using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double needeMoney = 0;

            if (budget<=100)
            {
                if (season == "summer")
                {
                    needeMoney = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", needeMoney);
                }

                else
                {
                    needeMoney = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", needeMoney);
                }
            }

            else if (budget<=1000)
            {
                if (season == "summer")
                {
                    needeMoney = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", needeMoney);
                }

                else
                {
                    needeMoney = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", needeMoney);
                }
            }

            else if(budget>1000)
            {
                needeMoney = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", needeMoney);
            }
        }
    }
}
