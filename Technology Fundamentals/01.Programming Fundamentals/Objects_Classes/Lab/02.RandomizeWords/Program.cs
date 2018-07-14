using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Random randomize = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int newIndex = randomize.Next(input.Length);

                string temp = input[i];
                input[i] = input[newIndex];
                input[newIndex] = temp;
            }

            Console.WriteLine(String.Join("\r\n", input));

        }
    }
}
