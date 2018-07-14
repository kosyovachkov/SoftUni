using System;
using System.Collections.Generic;
using System.Linq;

public class PowerPlants
{
    static void Main()
    {
        int[] flowers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int daysCount = 0;
        long sum = flowers.Sum();

        while (sum != 0)
        {
            for (int i = 0; i < flowers.Length; i++)
            {
                daysCount++;

                for (int j = 0; j < flowers.Length; j++)
                {
                    if (j != i && flowers[j] > 0)
                    {
                        flowers[j]--;
                        sum = flowers.Sum();
                        if (sum == 0)
                        {
                            break;
                        }
                    }

                    if (i == flowers.Length - 1 && flowers[j] != 0)
                    {
                        flowers[j]++;
                    }
                }
                if (sum == 0)
                {
                    break;
                }
            }


        }

        int seasons = (daysCount - 1) / flowers.Length;

        Console.WriteLine("survived {0} days ({1} seasons)", daysCount, seasons);
    }
}

