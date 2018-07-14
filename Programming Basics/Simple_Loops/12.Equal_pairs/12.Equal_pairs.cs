using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int newSum = 0;
            int diff = 0;
            int newDiff = 0;
            

            for (int i = 0; i < numbers; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                newSum = n1 + n2;
                if (i == 0)
                {
                    sum = newSum;
                }

                newDiff = Math.Abs(newSum - sum);

                if (newDiff > diff)
                {
                    diff = newDiff;
                }

                sum = newSum;
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }

            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
            }

            
        }
    }
}
