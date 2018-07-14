using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Numbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double average = numbers.Average();

            List<int> results = new List<int>();

            foreach (var item in numbers)
            {
                if (item > average)
                {
                    results.Add(item);
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("No");
            }

            else
            {
                results.Sort();
                results.Reverse();
                Console.WriteLine(string.Join(" ", results.Take(5)));
            }


        }
    }
}
