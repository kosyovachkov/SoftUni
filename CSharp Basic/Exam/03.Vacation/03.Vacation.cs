using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int sleepingNights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double priceOldPeople = 1;
            double priceStudents = 1;

            switch (transport)
            {
                case "train":
                    priceOldPeople = 24.99 * oldPeople;
                    priceStudents = 14.99 * students;
                    if (oldPeople + students > 50)
                    {
                        priceOldPeople = 24.99 * oldPeople * 0.5;
                        priceStudents = 14.99 * students * 0.5;
                    }
                    break;

                case "bus":
                    priceOldPeople = 32.50 * oldPeople;
                    priceStudents = 28.50 * students;
                    break;

                case "boat":
                    priceOldPeople = 42.99 * oldPeople;
                    priceStudents = 39.99 * students;
                    break;

                case "airplane":
                    priceOldPeople = 70.00 * oldPeople;
                    priceStudents = 50.00 * students;
                    break;

                default:
                    break;
            }

            double priceTransport = priceStudents*2 + priceOldPeople*2;
            double priceSleeping = 82.99 * sleepingNights;

            double commission = (priceTransport + priceSleeping) * 0.1;

            double fullPrice = priceTransport + priceSleeping + commission;

            Console.WriteLine("{0:f2}", fullPrice);

        }
    }
}
