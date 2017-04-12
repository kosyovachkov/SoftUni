using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    sumEven += chislo;
                }

                else
                {
                    sumOdd += chislo;
                }

            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumEven);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumEven-sumOdd));
            }


        }
    }
}
