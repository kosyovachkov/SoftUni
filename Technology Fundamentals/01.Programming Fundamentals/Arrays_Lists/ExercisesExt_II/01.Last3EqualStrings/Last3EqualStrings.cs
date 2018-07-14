using System;
using System.Collections.Generic;

public class ProgrLast3EqualStringsam
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        bool isMatch = false;
        string word = null;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == input[i-1]&&input[i]==input[i-2])
            {
                isMatch = true;
                word = input[i];
                break;
            }
        }

        if (isMatch)
        {
            Console.WriteLine("{0} {0} {0}", word);
        }
    }
}

