using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("{0}**{0}", new String('-', n/2-1));
            }

            else
            {
                Console.WriteLine("{0}*{0}", new String('-', n / 2));
            }

            if (n == 2)
            {
                Console.WriteLine("||");
            }


            for (int row = 2; row <= (n-1) / 2 + 1; row++)
            {

                int dashes = (n + 1) / 2 - row;

                Console.WriteLine("{0}{1}{0}", new String('-', dashes), new String('*', (n-(dashes *2))));
            }

            if (n>2)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("|{0}|", new String('*', n - 2));
                }
            }

            

        }
    }
}
