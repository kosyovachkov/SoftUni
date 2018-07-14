namespace ArrayModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayModifier
    {
        static void Main()
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] commandLine = input.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "swap":
                        int firtsIndex = int.Parse(commandLine[1]);
                        int secondIndex = int.Parse(commandLine[2]);
                        array = ArrSwap(array, firtsIndex, secondIndex);
                        break;
                    case "multiply":
                        firtsIndex = int.Parse(commandLine[1]);
                        secondIndex = int.Parse(commandLine[2]);
                        array = ArrMultiply(array, firtsIndex, secondIndex);
                        break;
                    case "decrease":
                        array = ArrDecrease(array);
                        break;

                    default:
                        break;
                }


                input = Console.ReadLine();
            }


            Console.WriteLine(string.Join(", ", array));
        }

        private static long[] ArrDecrease(long[] array)
        {
            long[] result = new long[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] - 1;
            }

            return result;
        }

        private static long[] ArrMultiply(long[] array, int firtsIndex, int secondIndex)
        {
            long result = array[firtsIndex] * array[secondIndex];
            array[firtsIndex] = result;
            return array;
        }

        private static long[] ArrSwap(long[] array, int firtsIndex, int secondIndex)
        {
            long temp = array[firtsIndex];
            array[firtsIndex] = array[secondIndex];
            array[secondIndex] = temp;

            return array;
        }
    }
}
