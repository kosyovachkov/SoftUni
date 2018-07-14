using System;
using System.Linq;


namespace MaxSequenceIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int l = numbers.Length;

            int currentCount = 0;
            int startIndex = 0;
            int maxCount = 0;
            int maxStartIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    currentCount++;
                    startIndex = i - currentCount;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxStartIndex = startIndex;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }
            for (int i = maxStartIndex; i <= (maxStartIndex + maxCount); i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}