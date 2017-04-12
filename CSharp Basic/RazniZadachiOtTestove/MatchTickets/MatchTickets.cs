using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double moneyForTransport = 0;
            

            double neededMoney = 0;


            if (numberOfPeople >= 50)
            {
                moneyForTransport = 0.25 * budget;
            }
            else if (numberOfPeople >= 25)
            {
                moneyForTransport = 0.4 * budget;
            }
            else if (numberOfPeople>=10)
            {
                moneyForTransport = 0.5 * budget;
            }
            else if (numberOfPeople>=5)
            {
                moneyForTransport = 0.6 * budget;
            }
            else
            {
                moneyForTransport = 0.75 * budget;
            }

            double restMoney = budget - moneyForTransport;

            if (category == "VIP")
            {
                neededMoney = numberOfPeople * 499.99;
            }
            else
            {
                neededMoney = numberOfPeople * 249.99;
            }

            if (restMoney>=neededMoney)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", restMoney-neededMoney);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", neededMoney-restMoney);
            }
        }
    }
}
