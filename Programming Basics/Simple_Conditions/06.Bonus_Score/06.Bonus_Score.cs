using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusOne = 0.0;
            double bonusTwo = 0.0;


            if (number <= 100 && number >= 0)
            {
                bonusOne = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusOne = number * 0.2;
            }

            else if (number > 1000)
            {
                bonusOne = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonusTwo = 1;
            }

            if (number % 10 == 5)
            {
                bonusTwo = 2;
            }

            double bonusAll = bonusOne + bonusTwo;

            Console.WriteLine(bonusAll);
            Console.WriteLine(number + bonusAll);


        }
    }
}
