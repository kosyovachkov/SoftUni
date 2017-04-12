using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                sum += number;
            }

            int newSum = sum - maxNumber;

            if (newSum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNumber);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(newSum - maxNumber));
            }
        }
    }
}
