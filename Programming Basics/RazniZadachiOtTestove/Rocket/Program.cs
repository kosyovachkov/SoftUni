using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outreDots = 3 * n - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outreDots / 2), new string(' ', 2 * i));
                outreDots -= 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n / 2 - i), new string('*', n * 2 - 2 + 2 * i));
            }
        }
    }
}
