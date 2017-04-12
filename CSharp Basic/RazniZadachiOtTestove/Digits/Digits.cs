using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lastNum = n % 10;
            int twoDigit = n / 10;
            int midNum = twoDigit % 10;
            int firstNum = n / 100;

            int rows = firstNum + midNum;
            int col = firstNum + lastNum;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstNum;
                    }
                    else if (n%3==0)
                    {
                        n -= midNum;
                    }

                    else 
                    {
                        n += lastNum;
                    }

                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
