using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] phonenumbers = Console.ReadLine().Split();
        string[] names = Console.ReadLine().Split();

        string input = Console.ReadLine();

        while (!input.Equals("done"))
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (input.Equals(names[i]))
                {
                    Console.WriteLine($"{names[i]} -> {phonenumbers[i]}");
                }
            }

            input = Console.ReadLine();
        }
    }
}

