using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniAirline
{
   public class SoftUniAirline
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<decimal> average = new List<decimal>(); 

            for (int i = 0; i < n; i++)
            {
                int adultCount = int.Parse(Console.ReadLine());
                decimal adultPrice = decimal.Parse(Console.ReadLine());
                int youthCount = int.Parse(Console.ReadLine());
                decimal youthPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int duration = int.Parse(Console.ReadLine());

                decimal income = (adultCount * adultPrice) + (youthCount * youthPrice);
                decimal expenses = fuelConsumption * fuelPrice * duration;

                decimal profit = income - expenses;
                average.Add(profit);

                if (profit>=0)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", profit);
                }

                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost -{0:f3}$.", Math.Abs(profit));
                }
            }

            decimal sum = average.Sum();
            decimal averageFinal = average.Average();

            Console.WriteLine("Overall profit -> {0:f3}$.", sum);
            Console.WriteLine("Average profit -> {0:f3}$.", averageFinal);
        }
    }
}
