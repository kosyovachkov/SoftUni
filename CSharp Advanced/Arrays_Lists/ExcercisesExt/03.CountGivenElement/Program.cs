using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountGivenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());

            int counter = 0;

            foreach (var item in arr)
            {
                if (item == element)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
