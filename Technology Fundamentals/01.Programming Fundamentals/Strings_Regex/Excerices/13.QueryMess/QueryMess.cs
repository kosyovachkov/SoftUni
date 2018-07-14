namespace _13.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            Regex pairRegex = new Regex(@"[^&=?]*=[^&=?]*");
            Regex groupRegex = new Regex(@"(\+|(%20))+");

            while (!text.Equals("END"))
            {
                Dictionary<string, List<string>> finalPairs = new Dictionary<string, List<string>>();

                MatchCollection pairMatches = pairRegex.Matches(text);

                foreach (Match match in pairMatches)
                {
                    string replacedMatch = groupRegex.Replace(match.Value, " ");

                    string[] replaced = replacedMatch.Split('=');
                    string key = replaced[0].Trim();
                    string value = replaced[1].Trim();

                    if (!finalPairs.ContainsKey(key))
                    {
                        finalPairs[key] = new List<string>();
                    }
                    finalPairs[key].Add(value);
                }
                
                foreach (var pair in finalPairs)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();

                text = Console.ReadLine();
            }
        }
    }
}
