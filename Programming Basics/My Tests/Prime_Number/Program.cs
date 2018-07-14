using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n<2)
            {
                Console.WriteLine("Not Prime");
            }

            else
            {

            

            bool isPrime = true;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % (i+1) == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

            }
        }
    }
}
