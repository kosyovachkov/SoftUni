using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double cenaProducts = 0;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    cenaProducts = 0.50 * quantity;
                }

                else if (product == "water")
                {
                    cenaProducts = 0.80 * quantity;
                }

                else if (product == "beer")
                {
                    cenaProducts = 1.20 * quantity;
                }

                else if (product == "sweets")
                {
                    cenaProducts = 1.45 * quantity;
                }

                else
                {
                    cenaProducts = 1.60 * quantity;
                }
            }

            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    cenaProducts = 0.40 * quantity;
                }

                else if (product == "water")
                {
                    cenaProducts = 0.70 * quantity;
                }

                else if (product == "beer")
                {
                    cenaProducts = 1.15 * quantity;
                }

                else if (product == "sweets")
                {
                    cenaProducts = 1.30 * quantity;
                }

                else
                {
                    cenaProducts = 1.50 * quantity;
                }
            }

            else
            {
                if (product == "coffee")
                {
                    cenaProducts = 0.45 * quantity;
                }

                else if (product == "water")
                {
                    cenaProducts = 0.70 * quantity;
                }

                else if (product == "beer")
                {
                    cenaProducts = 1.10 * quantity;
                }

                else if (product == "sweets")
                {
                    cenaProducts = 1.35 * quantity;
                }

                else
                {
                    cenaProducts = 1.55 * quantity;
                }
            }

            Console.WriteLine(cenaProducts);
        }
    }
}
