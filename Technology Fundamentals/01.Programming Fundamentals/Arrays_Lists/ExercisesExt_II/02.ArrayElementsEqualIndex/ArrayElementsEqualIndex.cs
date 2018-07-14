using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayElementsEqualIndex
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].Equals(i))
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();

    }
}

