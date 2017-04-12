using System;
using System.Collections.Generic;
using System.Linq;


namespace TrophonCat
{
    public class TrophonCat
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int beginIndex = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            long leftSum = 0;
            long rightSum = 0;

            if (typeOfItems.Equals("cheap"))
            {
                //to do logic
                leftSum = LeftSumCheap(arr, beginIndex, typeOfPrice);
                rightSum = RightSumCheap(arr, beginIndex, typeOfPrice);
            }

            else
            {
                //to do logic
                leftSum = LeftSumExp(arr, beginIndex, typeOfPrice);
                rightSum = RightSumExp(arr, beginIndex, typeOfPrice);
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }

        private static long RightSumCheap(long[] arr, int beginIndex, string typeOfPrice)
        {
            long sum = 0;

            switch (typeOfPrice)
            {

                case "positive":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] > 0 && arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "negative":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] < 0 && arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "all":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                default:
                    break;
            }
            return sum;
        }

        private static long LeftSumCheap(long[] arr, int beginIndex, string typeOfPrice)
        {
            long sum = 0;

            switch (typeOfPrice)
            {
                case "positive":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] > 0 && arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "negative":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] < 0 && arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "all":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] < arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                default:
                    break;
            }
            return sum;
        }


        private static long RightSumExp(long[] arr, int beginIndex, string typeOfPrice)
        {
            long sum = 0;

            switch (typeOfPrice)
            {

                case "positive":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] > 0 && arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "negative":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] < 0 && arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "all":
                    for (int i = beginIndex + 1; i < arr.Length; i++)
                    {
                        if (arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                default:
                    break;
            }
            return sum;
        }

        private static long LeftSumExp(long[] arr, int beginIndex, string typeOfPrice)
        {
            long sum = 0;

            switch (typeOfPrice)
            {
                case "positive":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] > 0 && arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "negative":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] < 0 && arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                case "all":
                    for (int i = 0; i < beginIndex; i++)
                    {
                        if (arr[i] >= arr[beginIndex])
                        {
                            sum += arr[i];
                        }
                    };
                    break;
                default:
                    break;
            }
            return sum;
        }


    }
}
