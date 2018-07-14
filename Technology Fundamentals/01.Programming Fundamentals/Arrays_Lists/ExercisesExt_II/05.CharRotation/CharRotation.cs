using System;
using System.Collections.Generic;
using System.Linq;

public class CharRotation
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        char[] result = new char[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result[i] = (char)(text[i] - (numbers[i]));
            }

            else
            {
                result[i] = (char)(text[i] + (numbers[i]));
            }
        }

        Console.WriteLine(String.Join("", result));
    }
}

