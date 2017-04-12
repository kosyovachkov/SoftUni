using System;
using System.Linq;


public class Ladybugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 0 && input[i] < n)
            {
                array[input[i]] = 1;
            }
        }

        string text = Console.ReadLine();

        while (!text.Equals("end"))
        {
            string[] commands = text.Split();
            int indexBug = int.Parse(commands[0]);
            string direction = commands[1];
            int steps = int.Parse(commands[2]);

            if (direction == "right" && steps > 0)
            {
                array = MoveRight(array, indexBug, steps);
            }

            if (direction == "right" && steps < 0)
            {
                array = MoveLeft(array, indexBug, steps * (-1));
            }

            if (direction == "left" && steps > 0)
            {
                array = MoveLeft(array, indexBug, steps);
            }

            if (direction == "left" && steps < 0)
            {
                array = MoveRight(array, indexBug, steps * (-1));
            }


            text = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", array));
    }

    private static int[] MoveLeft(int[] array, int indexBug, int steps)
    {
        if (indexBug >= 0 && indexBug < array.Length)
        {

            if (array[indexBug] == 1)
            {
                int currentIndex = indexBug;
                indexBug -= steps;
                if (indexBug >= 0)
                {
                    while (array[indexBug] == 1 && indexBug >= 0)
                    {
                        indexBug -= steps;
                    }

                    if (indexBug < 0)
                    {
                        array[currentIndex] = 0;
                    }
                    else
                    {
                        array[indexBug] = 1;
                        array[currentIndex] = 0;
                    }

                }

                else
                {
                    array[currentIndex] = 0;
                }
            }
        }
        return array;
    }

    private static int[] MoveRight(int[] array, int indexBug, int steps)
    {
        if (indexBug >= 0 && indexBug < array.Length)
        {
            if (array[indexBug] == 1)
            {
                int currentIndex = indexBug;
                indexBug += steps;
                if (indexBug < array.Length)
                {
                    while (indexBug < array.Length && array[indexBug] == 1)
                    {
                        indexBug += steps;
                    }
                    if (indexBug >= array.Length)
                    {
                        array[currentIndex] = 0;
                    }
                    else
                    {
                        array[indexBug] = 1;
                        array[currentIndex] = 0;
                    }
                }

                else
                {
                    array[currentIndex] = 0;
                }
            }
        }


        return array;
    }
}
