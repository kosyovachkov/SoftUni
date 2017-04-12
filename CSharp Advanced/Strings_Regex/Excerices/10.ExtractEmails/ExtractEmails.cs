namespace _10.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<=\s)[a-z1-9]+(\.|-)*?[a-z1-9]*@\w+-?\w+?\.\w+\.*\b\w*");
            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
