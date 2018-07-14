using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part

            int row = 1;
            int leftDashesToMiddle = n * 3;
            int middleDashesToMiddle = row - 1;
            int rightDashesToMiddle = (5 * n) - leftDashesToMiddle - (row + 1);

            for (row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new String('-', leftDashesToMiddle), new String('-', middleDashesToMiddle), new String('-', rightDashesToMiddle));
                middleDashesToMiddle++;
                rightDashesToMiddle--;
            }

            //middle part

            for (row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}*{1}", new String('*', n * 3 + 1), new String('-', n - 1));
            }

            // bottom part

            int leftDashesToBottom = n * 3;
            int middleDashesToBottom = n - 1;
            int rightDashesToBottom = n - 1;

            for (row = 1; row <= n / 2 - 1; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new String('-', leftDashesToBottom), new String('-', middleDashesToBottom), new String('-', rightDashesToBottom));
                leftDashesToBottom--;
                middleDashesToBottom += 2;
                rightDashesToBottom--;
            }


            //last row

            
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}", new String('-', 5 * n - (2 * n - 1) - (n / 2)), new String('*', 2 * n - 1), new String('-', n/2));
            }

            else
            {
                Console.WriteLine("{0}{1}{2}", new String('-', 5 * n - (2 * n - 2) - (n / 2 + 1)), new String('*', 2 * n - 2), new String('-', n / 2 + 1));
            }
        }
    }
}

//Решена за 40.25