using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int futureYear = int.Parse(Console.ReadLine());

            int pastYeras = futureYear - 1800;

            double spendMoney = 0;
            double restMoney = money;

            for (int i = 0; i <= pastYeras; i++)
            {
                if (i % 2 == 0)
                {
                    spendMoney = 12000;
                    restMoney -= spendMoney;
                }
                else
                {
                    spendMoney = 12000 + (50 * (18 + i));
                    restMoney -= spendMoney;
                }
            }

            if (restMoney >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", restMoney);
            }

            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(restMoney));
            }
        }
    }
}
