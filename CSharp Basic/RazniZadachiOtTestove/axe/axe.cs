using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axe
{
    class axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftDashes = n * 3;
            int innerDashes = 0;
            int rightdashes = 2 * n - 2;

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', innerDashes), new string('-', rightdashes));
                innerDashes++;
                rightdashes--;
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', innerDashes), new string('-', rightdashes));

            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', innerDashes), new string('-', rightdashes));
            }

            for (int i = 1; i <= n/2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', innerDashes), new string('-', rightdashes));
                innerDashes+=2;
                rightdashes--;
                leftDashes--;
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', innerDashes), new string('-', rightdashes));




        }
    }
}
