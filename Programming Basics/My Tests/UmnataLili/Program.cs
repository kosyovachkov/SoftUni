using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnataLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double currentSum = 0;
            double sum = 0;

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    currentSum += 10;
                    sum+=currentSum;
                    sum -= 1;
                }

                else
                {
                    sum += toyPrice;
                }
            }

            if (sum>=laundryPrice)
            {
                Console.WriteLine("Yes! {0:f2}", sum-laundryPrice);
            }

            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(laundryPrice-sum));
            }
        }
    }
}

