using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    static void Main()
    {
        List<long> arr = Console.ReadLine().Split().Select(long.Parse).ToList();

        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] commandLine = input.Split();
            string command = commandLine[0];

            switch (command)
            {
                case "exchange":
                    int index = int.Parse(commandLine[1]);
                    if (index >=arr.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }
                    else
                    {
                       arr = ExchangeIndex(arr, index);
                    }
                    break;

                case "max":
                    string manipulator = commandLine[1];
                    MaxEvenOrOdd(arr, manipulator);
                    break;

                case "min":
                    string manipulator2 = commandLine[1];
                    MinEvenOrOdd(arr, manipulator2);
                    break;

                case "first":
                    int numbers1 = int.Parse(commandLine[1]);
                    string manipulator3 = commandLine[2];
                    FirstEvenOrOdd(arr, numbers1, manipulator3);
                    break;
                case "last":
                    int numbers2 = int.Parse(commandLine[1]);
                    string manipulator4 = commandLine[2];
                    LastEvenOrOdd(arr, numbers2, manipulator4);
                    break;

            }


            input = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }

    private static void LastEvenOrOdd(List<long> arr, int numbers2, string manipulator4)
    {
        List<long> result = new List<long>();
        long count = 0;
        //int[] result = new int[numbers2];
        if (numbers2 <= arr.Count && numbers2 >= 0)
        {
            
            if (manipulator4.Equals("even"))
            {
                for (int j = arr.Count - 1; j >= 0; j--)
                {
                    if (arr[j] % 2 == 0)
                    {
                        result.Add(arr[j]);
                        count++;
                        if (count == numbers2)
                        {
                            break;
                        }
                    }
                }
            }

            else if (manipulator4.Equals("odd"))
            {
                for (int j = arr.Count - 1; j >= 0; j--)
                {
                    if (arr[j] % 2 != 0)
                    {
                        result.Add(arr[j]);
                        count++;
                        if (count == numbers2)
                        {
                            break;
                        }
                    }
                }
            }

            result.Reverse();

            Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        else
        {
            Console.WriteLine("Invalid count");
        }
    }

    private static void FirstEvenOrOdd(List<long> arr, int numbers1, string manipulator3)
    {
        List<long> result = new List<long>();
        long count = 0;
        if (numbers1 <= arr.Count && numbers1 >= 0)
        {
            
            if (manipulator3.Equals("even"))
            {
                
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] % 2 == 0)
                    {
                        result.Add(arr[j]);
                        count++;
                        if (count == numbers1)
                        {
                            break;
                        }
                    }
                }
            }
            else if (manipulator3.Equals("odd"))
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] % 2 != 0)
                    {
                        result.Add(arr[j]);
                        count++;
                        if (count == numbers1)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        else
        {
            Console.WriteLine("Invalid count");
        }

    }


    private static void MinEvenOrOdd(List<long> arr, string manipulator2)
    {
        long minNum = long.MaxValue;
        bool isFound = false;
        long index = 0;

        if (manipulator2.Equals("even"))
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minNum)
                {
                    minNum = arr[i];
                    isFound = true;
                    index = i;
                }
            }
        }

        else if (manipulator2.Equals("odd"))
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= minNum)
                {
                    minNum = arr[i];
                    isFound = true;
                    index = i;
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No matches");
        }

        else
        {
            Console.WriteLine(index);
        }
    }

    private static void MaxEvenOrOdd(List<long> arr, string manipulator)
    {
        long maxNum = long.MinValue;
        long currentIndex = 0;
        bool isFound = false;

        if (manipulator.Equals("even"))
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxNum)
                {
                    maxNum = arr[i];
                    currentIndex = i;
                    isFound = true;
                }
            }
        }

        else if (manipulator.Equals("odd"))
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= maxNum)
                {
                    maxNum = arr[i];
                    currentIndex = i;
                    isFound = true;
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(currentIndex);
        }
    }

    private static List<long> ExchangeIndex(List<long> arr, int index)
    {
        List<long> result = arr.Skip(index + 1).ToList();
        result.AddRange(arr.Take(index + 1));

        //int[] firstPart = arr.Take(index + 1).ToArray();
        //int[] secondPart = arr.Skip(index + 1).Take(int.MaxValue).ToArray();
        //int[] result = secondPart.Concat(firstPart).ToArray();
        return result;

    }
}

