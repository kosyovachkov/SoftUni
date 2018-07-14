using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string patternLetter = @"[^\d\*\.\+\/-]";
            string patterNumbers = @"(\-|\+)*([0-9]+\.)*[0-9]+";


            Regex firstRegex = new Regex(patternLetter);
            Regex secondRegex = new Regex(patterNumbers);
            Regex multiplyer = new Regex(@"\*");
            Regex divider = new Regex(@"\/");

            SortedDictionary<string, Dictionary<string, double>> players = new SortedDictionary<string, Dictionary<string, double>>();

            for (int i = 0; i < input.Length; i++)
            {
                Dictionary<string, double> scores = new Dictionary<string, double>();
                scores["health"] = 0;
                scores["damage"] = 0;

                //letters

                MatchCollection matchesLetters = firstRegex.Matches(input[i]);
                double sum = 0;

                foreach (Match item in matchesLetters)
                {
                    char word = char.Parse(item.Value);
                    sum += word;
                }

                if (!players.ContainsKey(input[i]))
                {
                    players[input[i]] = scores;
                }
                players[input[i]]["health"] = sum;

                //numbers

                MatchCollection matchesNumbers = secondRegex.Matches(input[i]);
                double sum2 = 0;

                foreach (Match number in matchesNumbers)
                {
                    double num = double.Parse(number.Value);
                    sum2 += num;
                }
                if (sum2 == 0)
                {
                    continue;
                }

                MatchCollection multi = multiplyer.Matches(input[i]);
                if (multi.Count > 0)
                {
                    sum2 = sum2 * Math.Pow(2, multi.Count);
                }

                MatchCollection devide = divider.Matches(input[i]);
                if (devide.Count > 0)
                {
                    sum2 = sum2 / Math.Pow(2, devide.Count);
                }


                players[input[i]]["damage"] = sum2;

            }

            foreach (var item in players)
            {
                string deamon = item.Key;
                List<double> results = new List<double>();

                foreach (var dict in item.Value)
                {
                    results.Add(dict.Value);
                }

                Console.WriteLine("{0} - {1} health, {2:f2} damage", deamon, results[0], results[1]);
            }
        }
    }
}
