using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountNegativeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;

            foreach (var item in arr)
            {
                if (item<0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
