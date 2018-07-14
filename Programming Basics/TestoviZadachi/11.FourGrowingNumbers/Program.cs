using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FourGrowingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - a < 3)
            {
                Console.WriteLine("no");
            }


            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    for (int k = j + 1; k <= b; k++)
                    {
                        for (int l = k + 1; l <= b; l++)
                        {
                            
                            Console.WriteLine($"{i} {j} {k} {l}");
                           

                        }
                    }
                }
            }
        }
    }
}
