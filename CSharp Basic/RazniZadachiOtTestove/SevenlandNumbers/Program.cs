using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenlandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            if (k > 5 && k < 66 && (k % 10 == 6))
            {
                k += 3;
                Console.WriteLine(k + 1);
            }

            else if ((k > 65 && k < 666) && (k % 100 == 66))
            {

                k += 33;
                Console.WriteLine(k + 1);
            }

            else if ((k > 65 && k < 666) && (k % 10 == 6) && (k % 100 != 66))
            {

                k += 3;
                Console.WriteLine(k + 1);
            }

            else if (k == 666)
            {
                k += 333;
                Console.WriteLine(k + 1);
            }

            else
            {
                Console.WriteLine(k + 1);
            }



            //int n = int.Parse(Console.ReadLine());
            //if (n == 666)
            //{
            //    n = 1000;
            //}
            //else if ((n % 100) == 66)
            //{
            //    n += 34;
            //}
            //else if (n % 10 != 6)
            //{
            //    n++;
            //}
            //else if (n % 10 == 6)
            //{
            //    n += 4;
            //}

            //Console.WriteLine(n);
        }
    }
}
