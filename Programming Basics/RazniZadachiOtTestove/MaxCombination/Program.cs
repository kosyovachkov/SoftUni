using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    if (counter >= stopNumber)
                    {
                        break;
                    }

                    Console.Write($"<{i}-{j}>");
                    counter++;
                }
            }

            Console.WriteLine();
        }
    }
}
