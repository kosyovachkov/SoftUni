using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                string[] commandLine = input.Split().ToArray();

                string manipulator = commandLine[0];

                if (manipulator == "add")
                {
                    numbers = AddElement(commandLine, numbers);
                }

                else if (manipulator == "addMany")
                {
                    numbers = AddMany(commandLine, numbers);
                }

                else if (manipulator == "contains")
                {
                    ContainsElement(commandLine, numbers);
                }

                else if (manipulator == "remove")
                {
                    numbers = RemoveElements(commandLine, numbers);
                }

                else if (manipulator == "shift")
                {
                    numbers = ShiftElements(commandLine, numbers);
                }

                else if (manipulator == "sumPairs")
                {
                    numbers = SumPairs(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));



        }
        private static List<int> AddElement(string[] commandLine, List<int> numbers)
        {


            int index = int.Parse(commandLine[1]);

            int newNumber = int.Parse(commandLine[2]);

            numbers.Insert(index, newNumber);
            return numbers;
        }

        private static List<int> AddMany(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);
            List<int> nums = new List<int>();

            for (int j = 2; j < commandLine.Length; j++)
            {
                nums.Add(int.Parse(commandLine[j]));
            }
            numbers.InsertRange(index, nums);

            return numbers;
        }

        private static void ContainsElement(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);
            Console.WriteLine(numbers.IndexOf(index));
        }

        private static List<int> RemoveElements(string[] commandLine, List<int> numbers)
        {

            int index = int.Parse(commandLine[1]);
            numbers.RemoveAt(index);

            return numbers;
        }

        private static List<int> ShiftElements(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);

            for (int i = 0; i < index; i++)
            {
                int firstElement = numbers[0];

                for (int j = 0; j < numbers.Count- 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstElement;
            }

            return numbers;
        }

        private static List<int> SumPairs(List<int> numbers)
        {
            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                sum.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 == 1)
            {
                sum.Add(numbers[numbers.Count - 1]);
            }

            numbers = sum;

            return numbers;
        }


    }
}
