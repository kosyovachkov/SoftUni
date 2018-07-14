using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2 * n + n / 3; i++)
            {
                if (i <= n)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', 2 * n - 2 * i));

                }

                if (i > n && i <= n + n / 3)
                {
                    Console.WriteLine("|{0}\\{1}/{0}|", new string('*', i - n + 3), new string('*', n));
                    n -= 2;
                }
            }
        }
    }
}
