﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> nums = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (nums.ContainsKey(number))
                {
                    nums[number]++;
                }
                else
                {
                    nums[number] = 1;
                }
            }

            foreach (KeyValuePair<double, int> pair in nums)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }


        }
    }
}
