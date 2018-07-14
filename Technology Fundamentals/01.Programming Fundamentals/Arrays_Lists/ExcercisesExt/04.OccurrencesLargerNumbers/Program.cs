using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OccurrencesLargerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double n = double.Parse(Console.ReadLine());
            int counter = 0;

            foreach (var item in arr)
            {
                if (item>n)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
