using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;

            if (n>=100)
            {
                price = n * 0.06;
            }

            else if (n>=20)
            {
                price = n * 0.09;
            }

            else
            {
                if (dayOrNight == "day")
                {
                    price = 0.7 + n * 0.79;
                }

                else
                {
                    price = 0.7 + n * 0.9;
                }
            }

            Console.WriteLine(price);
        }
    }
}
