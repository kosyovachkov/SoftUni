using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int counter = 0;

            foreach (var item in arr)
            {
                if (item.Length == 1 && char.Parse(item) >= 65 && char.Parse(item) <= 90)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

            // С LINQ

            //char[] arr = Console.ReadLine().Split().Where(w => w.Length == 1).Select(char.Parse).Where(x => x >= 65 && x <= 90).ToArray();

            //Console.WriteLine(arr.Length);
        }
    }
}
