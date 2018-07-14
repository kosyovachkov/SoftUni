using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper bottom part

            Console.WriteLine("{0}{1}{0}", new String('*', n * 2), new String(' ', n));

            //glasses
            for (int row = 0; row < n-2; row++)
            {
                Console.Write("*{0}*", new String('/', n * 2 - 2));

                if (row == (n - 1) / 2 - 1)
                {
                    Console.Write(new String('|', n));
                }

                else
                {
                    Console.Write(new string(' ', n));

                }
                Console.WriteLine("*{0}*", new String('/', n * 2 - 2));
            }

            //upper bottom part

            Console.WriteLine("{0}{1}{0}", new String('*', n * 2), new String(' ', n));
        }
    }
}
