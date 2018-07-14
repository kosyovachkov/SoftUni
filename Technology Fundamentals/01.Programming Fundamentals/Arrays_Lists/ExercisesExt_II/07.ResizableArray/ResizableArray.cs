using System;
using System.Collections.Generic;
using System.Linq;

public class ResizableArray
{
    static void Main()
    {
        int?[] nums = new int?[4];

        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] commandLine = input.Split();
            string command = commandLine[0];

            switch (command)
            {
                case "push":
                    int number = int.Parse(commandLine[1]);
                    nums = Push(nums, number);
                    break;
                case "pop":
                    nums = Pop(nums);
                    break;
                case "removeAt":
                    int number2 = int.Parse(commandLine[1]);
                    nums = RemoveAt(nums, number2);
                    break;
                case "clear":
                    nums = Clear(nums);
                    break;
                default:
                    break;
            }


            input = Console.ReadLine();
        }

        if (nums.Sum()!=0)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
        else
        {
            Console.WriteLine("empty array");
        }

        
    }

    private static int?[] Clear(int?[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = null;
        }

        return nums;
    }

    private static int?[] RemoveAt(int?[] nums, int number)
    {
        for (int i = number; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = null;

        return nums;
    }

    private static int?[] Pop(int?[] nums)
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i]!=null)
            {
                nums[i] = null;
                break;
            }
        }

        return nums;

    }

    public static int?[] Push(int?[] nums, int number)
    {
        bool isFull = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != null)
            {
                isFull = true;
            }

            else
            {
                break;
            }
        }

        if (isFull)
        {
            int?[] numsDouble = new int?[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                numsDouble[i] = nums[i];
            }
            nums = numsDouble;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == null)
            {
                nums[i] = number;
                break;
            }
            else
            {
                continue;
            }
        }


        return nums;
    }
}

