using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int min1 = Math.Min(Math.Min(n, m), k);
            int max1 = Math.Max(Math.Max(n, m), k);
            int mid = ((n + m + k) - min1 - max1);

            if (min1 + mid == max1)
            {
                Console.WriteLine($"{min1} + {mid} = {max1}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
