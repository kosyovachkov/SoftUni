using System;
using System.Collections.Generic;

public class CommandInterpreter
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string commandsInput = Console.ReadLine();

        while (!commandsInput.Equals("end"))
        {
            string[] commands = commandsInput.Split();
            if (commands[0].Equals("reverse"))
            {
                int start = int.Parse(commands[2]);
                int count = int.Parse(commands[4]);
                array = ReverseInput(array, start, count);
            }

            else if (commands[0].Equals("sort"))
            {
                int start = int.Parse(commands[2]);
                int count = int.Parse(commands[4]);
                array = SortInput(array, start, count);
            }

            else if (commands[0].Equals("rollLeft"))
            {
                int count = int.Parse(commands[1]);
                array = RollLeft(array, count);
            }

            else if (commands[0].Equals("rollRight"))
            {
                int count = int.Parse(commands[1]);
                array = RollRight(array, count);
            }

            commandsInput = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", array));
    }

    private static string[] RollRight(string[] array, int count)
    {
        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return array;
        }

        else
        {
            for (int i = 0; i < count % array.Length; i++)
                // За да не върти страшно много пъти. 
                // По този начин не превишавам TimeLimit-a на програмата. 
                // Примера със заека и часовника на Кенов!!!
            {
                string lastElement = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;
            }
            return array;
        }
    }

    private static string[] RollLeft(string[] array, int count)
    {
        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return array;
        }

        else
        {
            for (int i = 0; i < count % array.Length; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstElement;
            }
            return array;
        }
    }

    private static string[] SortInput(string[] array, int start, int count)
    {
        if (start < 0 || count < 0 || start >= array.Length || start + count > array.Length)
        {
            Console.WriteLine("Invalid input parameters.");
            return array;
        }

        else
        {
            string[] sortedArray = new string[array.Length];

            string[] partOfArray = new string[count];

            for (int i = 0; i < start; i++)
            {
                sortedArray[i] = array[i];
            }

            for (int i = 0; i < count; i++)
            {
                partOfArray[i] = array[start + i];
            }

            Array.Sort(partOfArray);

            for (int i = 0; i < count; i++)
            {
                sortedArray[start + i] = partOfArray[i];
            }

            for (int i = start + count; i < array.Length; i++)
            {
                sortedArray[i] = array[i];
            }
            return sortedArray;
        }
    }

    private static string[] ReverseInput(string[] array, int start, int count)
    {
        if (start < 0 || count < 0 || start >= array.Length || start + count > array.Length)
        {
            Console.WriteLine("Invalid input parameters.");
            return array;
        }

        else
        {
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < start; i++)
            {
                reversedArray[i] = array[i];
            }

            for (int i = 0; i < count; i++)
            {
                reversedArray[start + i] = array[start + count - i - 1];
            }

            for (int i = start + count; i < array.Length; i++)
            {
                reversedArray[i] = array[i];
            }
            return reversedArray;
        }
    }
}
