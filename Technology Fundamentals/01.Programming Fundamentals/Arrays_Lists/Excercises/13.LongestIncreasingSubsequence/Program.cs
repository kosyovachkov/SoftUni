using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] length = new int[numbers.Length];
            int[] previous = new int[numbers.Length];

            int maxLength = 0;
            int lastIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                previous[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] > numbers[j] && length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        previous[i] = j;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            int[] longestSequence = RestoreArray(numbers, previous, lastIndex);

            Console.WriteLine(string.Join(" ", longestSequence));

        }
        public static int[] RestoreArray(int[] numbers, int[] previous, int lastIndex)
        {
            List<int> longetsSequence = new List<int>();

            while (lastIndex != -1)
            {
                longetsSequence.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longetsSequence.Reverse();
            return longetsSequence.ToArray();

        }
    }
}
