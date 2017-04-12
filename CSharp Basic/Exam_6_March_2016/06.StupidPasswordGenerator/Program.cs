using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 'a'; k < ('a' + l); k++)
                    {
                        for (int m = 'a'; m < ('a' + l); m++)
                        {
                            for (int p = 2; p <= n; p++)
                            {
                                if (p > i && p > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, (char)k, (char)m, p);
                                    
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
