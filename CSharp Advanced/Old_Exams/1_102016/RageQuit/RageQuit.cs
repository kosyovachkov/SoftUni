using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


public class RageQuit
{
    static void Main()
    {
        string input = Console.ReadLine();

        Regex regexPairs = new Regex(@"([^\d]+)(\d{0,2})");

        MatchCollection matches = regexPairs.Matches(input);

        // List<char> finalString = new List<char>();

        StringBuilder result = new StringBuilder();

        foreach (Match pairs in matches)
        {
            int repeater = int.Parse(pairs.Groups[2].ToString());
            string text = pairs.Groups[1].ToString().ToUpper();

            for (int i = 0; i < repeater; i++)
            {
                result.Append(text);
            }
        }

        string finalResult = result.ToString();

        int count = finalResult.Distinct().Distinct().Count();
        
        Console.WriteLine($"Unique symbols used: {count}");
        Console.WriteLine(finalResult);

    }
}

