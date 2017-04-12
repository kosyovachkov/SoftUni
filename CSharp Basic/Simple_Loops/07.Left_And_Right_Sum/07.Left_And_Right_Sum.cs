using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                sum1 += n1;
            }

            for (int i = 0; i < numbers; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                sum2 += n2;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }

            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
