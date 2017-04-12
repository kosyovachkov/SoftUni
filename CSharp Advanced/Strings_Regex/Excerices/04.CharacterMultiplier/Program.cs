using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string textOne = input[0];
            string textTwo = input[1];
            int multiplyer = 0;

            if (textOne.Length==textTwo.Length)
            {
                multiplyer = MultiplyAndSumChars(textOne, textTwo);
            }
            else
            {
                if (textOne.Length > textTwo.Length)
                {
                    multiplyer = MultiplyAndSumChars(textOne, textTwo);
                    int currentSum = RemainingSum(textOne, textTwo);
                    multiplyer += currentSum;
                }

                else
                {
                    multiplyer = MultiplyAndSumChars(textOne, textTwo);
                    int currentSum = RemainingSum(textTwo, textOne);
                    multiplyer += currentSum;
                }
                
            }

            Console.WriteLine(multiplyer);
            
        }

        private static int RemainingSum(string textOne, string textTwo)
        {
            int sum = 0;

            for (int i = textOne.Length-1; i >= textTwo.Length; i--)
            {
                sum += textOne[i];
            }

            return sum;
        }

        private static int MultiplyAndSumChars(string textOne, string textTwo)
        {
            int loopLength = Math.Min(textOne.Length, textTwo.Length);
            int multiplyer = 0;

            for (int i = 0; i < loopLength; i++)
            {
                multiplyer += textOne[i] * textTwo[i];
            }

            return multiplyer;
        }
    }
}
