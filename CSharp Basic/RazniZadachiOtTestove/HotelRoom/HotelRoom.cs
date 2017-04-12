using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    apartmentPrice = 65.00; studioPrice = 50;
                    if (days > 14)
                    {
                        studioPrice *= 0.7; ;
                        apartmentPrice *= 0.9;
                    }
                    else if (days > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    apartmentPrice = 68.70; studioPrice = 75.20;

                    if (days > 14)
                    {
                        studioPrice *= 0.8; ;
                        apartmentPrice *= 0.9;
                    }
                    break;

                case "July":
                case "August":
                    apartmentPrice = 77.00; studioPrice = 76.00;
                    if (days > 14)
                    {
                        apartmentPrice *= 0.9;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice * days);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * days);


        }
    }
}
