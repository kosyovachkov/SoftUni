using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buterfly
{
    class Buterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper

            for (int i = 1; i <= n-2; i++)
            {
                if (i%2==0)
                {
                    Console.Write("{0}\\ /{0}", new string('-', n - 2));
                }

                else
                {
                    Console.Write("{0}\\ /{0}", new string('*', n - 2));
                }
                Console.WriteLine();
            }

            //mid
            Console.WriteLine("{0}@{0}", new string(' ', n-1));

            //down

            for (int i = n-2; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}/ \\{0}", new string('-', n - 2));
                }

                else
                {
                    Console.Write("{0}/ \\{0}", new string('*', n - 2));
                }
                Console.WriteLine();
            }


        }
    }
}
