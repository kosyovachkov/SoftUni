using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outerDashes = (n - 1) / 2;
            int inerDashes = 1;

            if (n <= 2)
            {
                Console.WriteLine(new String('*', n));
            }

            else
            {
                //upper half

                if (n % 2 != 0)
                {
                    Console.WriteLine("{0}*{0}", new String('-', outerDashes));
                    outerDashes--;

                    for (int rows = 1; rows <= n / 2; rows++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new String('-', outerDashes), new String('-', inerDashes));
                        outerDashes--;
                        inerDashes += 2;
                    }
                }

                else
                {
                    inerDashes = 0;
                    for (int rows = 1; rows <= n / 2; rows++)

                    {
                        Console.WriteLine("{0}*{1}*{0}", new String('-', outerDashes), new String('-', inerDashes));
                        outerDashes--;
                        inerDashes += 2;
                    }
                }

                //bottom half

                outerDashes = 1;
                inerDashes = n - 4;

                for (int row = n / 2 - 1; row >= 1; row--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new String('-', outerDashes), new String('-', inerDashes));
                    outerDashes++;
                    inerDashes -= 2;
                }

                if (n % 2 != 0)
                {
                    Console.WriteLine("{0}*{0}", new String('-', outerDashes));
                }
            }
        }
    }
}

