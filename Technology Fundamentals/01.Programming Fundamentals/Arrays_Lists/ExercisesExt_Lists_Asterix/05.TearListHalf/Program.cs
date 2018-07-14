using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> leftPart = new List<int>();
            List<int> rightPart = new List<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (i < inputNumbers.Length / 2)
                {
                    leftPart.Add(inputNumbers[i]);
                }

                else
                {
                    rightPart.Add(inputNumbers[i]);
                }
            }

            List<int> finalList = new List<int>();
            for (int i = 0; i < rightPart.Count; i++)
            {
                finalList.Add(rightPart[i] / 10);
                finalList.Add(leftPart[i]);
                finalList.Add(rightPart[i] % 10);
            }


            // Отдолу е решение само с масиви

            //int[] leftPart = new int[inputNumbers.Length / 2];
            //int[] rightPart = new int[inputNumbers.Length / 2];

            //for (int i = 0; i < leftPart.Length; i++)
            //{
            //    leftPart[i] = inputNumbers[i];
            //}
            //for (int i = 0; i < rightPart.Length; i++)
            //{
            //    rightPart[i] = inputNumbers[inputNumbers.Length / 2 + i];
            //}

            //int[] finalArray = new int[leftPart.Length * 3];

            //for (int i = 0; i < rightPart.Length; i++)
            //{
            //    int newleft = rightPart[i] / 10;
            //    int newRight = rightPart[i] % 10;

            //    finalArray[3 * i] = newleft;
            //    finalArray[3 * i + 1] = leftPart[i];
            //    finalArray[3 * i + 2] = newRight;

            //}

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
