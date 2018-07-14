namespace _12.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Za-z]\w{2,24}\b");

            MatchCollection matches = regex.Matches(input);

            int maxSum = 0;
            int index = 0;

            for (int i = 0; i < matches.Count - 1; i++)
            {
                int sum = matches[i].Length + matches[i + 1].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            }
            Console.WriteLine(matches[index]);
            Console.WriteLine(matches[index + 1]);



        }
    }
}
