using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Хотел_Роом
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());

            double priceForStudio = 1;
            double priceForApartment = 1;

            if (month == "may" || month == "october")
            {
                priceForStudio = 50.00*days;
                priceForApartment = 65.00*days;

                if (days>14)
                {
                    priceForStudio *= 0.7;
                }

               else if (days>7)
                {
                    priceForStudio *= 0.95;
                }


            }

            else if (month == "june" || month == "september")
            {
                priceForStudio = 75.20*days;
                priceForApartment = 68.70*days;

                if (days > 14)
                {
                    priceForStudio *= 0.8;
                }
            }

            else if (month == "july" || month == "august")
            {
                priceForStudio = 76.00*days;
                priceForApartment = 77.00*days;
            }

            if (days>14)
            {
                priceForApartment *= 0.9;
            }

            Console.WriteLine("Apartment: {0:F2} lv.", priceForApartment);
            Console.WriteLine("Studio: {0:F2} lv.", priceForStudio);
        }
    }
}


//Решена за 16.45 минути