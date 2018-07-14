using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.5;
                }

                else if (fruit == "apple")
                {
                    price = quantity * 1.2;
                }

                else if (fruit == "orange")
                {
                    price = quantity * 0.85;
                }

                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.45;
                }

                else if (fruit == "kiwi")
                {
                    price = quantity * 2.70;
                }

                else if (fruit == "pineapple")
                {
                    price = quantity * 5.50;
                }

                else if (fruit == "grapes")
                {
                    price = quantity * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine("{0:F2}", price);
            }

            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.70;
                }

                else if (fruit == "apple")
                {
                    price = quantity * 1.25;
                }

                else if (fruit == "orange")
                {
                    price = quantity * 0.90;
                }

                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.60;
                }

                else if (fruit == "kiwi")
                {
                    price = quantity * 3;
                }

                else if (fruit == "pineapple")
                {
                    price = quantity * 5.60;
                }

                else if (fruit == "grapes")
                {
                    price = quantity * 4.20;
                }

                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine("{0:F2}",price);
            }

            else
            {
                Console.WriteLine("error");
            }

            
        }
    }
}
