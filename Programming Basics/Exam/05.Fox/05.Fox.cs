using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part

            int outerAsterix = 1;
            int innerDashes = 2 * n - 1;


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', outerAsterix), new string('-', innerDashes));
                outerAsterix++;
                innerDashes -= 2;
            }

            //mid part

            int secondAsterix = ((2 * n + 3) - n - 4) / 2;
            int midAsterix = n;

            for (int i = 1; i <= n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', secondAsterix), new string('*', midAsterix));
                secondAsterix++;
                midAsterix -= 2;

            }

            //bottom part

            int outerDashes = 1;
            int innerAsterix = 2 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', outerDashes), new string('*', innerAsterix));
                outerDashes++;
                innerAsterix -= 2;
            }
        }
    }
}
