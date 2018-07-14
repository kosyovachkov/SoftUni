using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTests
{
    class ArraysTests
    {
        static void Main(string[] args)
        {
            //string[] text = Console.ReadLine().Split();

            //Console.WriteLine(text[2]);


            // =======================

            //string[] text = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    text[i] = Console.ReadLine();
            //}

            //Console.WriteLine(text[2]);

            //=========================

            //string[] text = Console.ReadLine().Split('-');

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}


            //=============================


            //string text = Console.ReadLine();
            //string[] textNew = text.Split();

            //Console.WriteLine(String.Join(",", textNew));

            //===================

            //string s = "there is a cat";
            //// Split string on spaces.
            //// ... This will separate all the words.
            //string[] words = s.Split(' ');
            //foreach (string tralala in words)
            //{
            //    Console.WriteLine(tralala);
            //}

            //============================

            //// This string is also separated by Windows line breaks.
            //string value = Console.ReadLine();

            //// Use a new char array of two characters (\r and \n).
            //// ... Breaks lines into separate strings.
            //// ... Use RemoveEntryEntries to make sure not empty strings are added.
            //char[] delimiters = new char[] { '\r', '\n' };
            //string[] parts = value.Split(delimiters,
            //                 StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    Console.WriteLine(parts[i]);
            //}


            //==============================

            //string[] text = Console.ReadLine().Split();
            //int[] numbers = new int[text.Length];

            //for (int i = 0; i < text.Length; i++)
            //{
            //    numbers[i] = int.Parse(text[i]);
            //}

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + "-");
            //}


            //===============================

            //string[] text = Console.ReadLine().Split();
            //int[] numbers = new int[text.Length];

            //for (int i = 0; i < text.Length; i++)
            //{
            //    numbers[i] = int.Parse(text[i]);
            //}

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();

            //==============================

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
                counts[num]++;
            for (int i = 0; i < counts.Length; i++)
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");


        }
    }
}
