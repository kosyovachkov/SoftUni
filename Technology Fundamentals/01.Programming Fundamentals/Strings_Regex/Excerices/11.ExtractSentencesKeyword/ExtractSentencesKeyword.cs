namespace _11.ExtractSentencesKeyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;


    public class ExtractSentencesKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            
            string text = Console.ReadLine();

            string[] array = text.Split('!', '.', '?');

            var regex = new Regex($@"\b{word}\.*?\b");

            foreach (var item in array)
            {
                
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item);   
                }

            }
        }
    }
}


//string pattern = @"[\w ]+\b" +wordNeeded+ @"\b[\w ]+[!.?]";
