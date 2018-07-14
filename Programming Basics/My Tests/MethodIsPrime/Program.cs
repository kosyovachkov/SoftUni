using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(num);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }

            }

            return isPrime;
        }
    }
}
