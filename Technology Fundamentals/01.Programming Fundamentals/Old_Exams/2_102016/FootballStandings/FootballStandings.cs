namespace FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class FootballStandings
    {
        public static void Main()
        {
            string separator = Console.ReadLine();

           // string pattern = @".*" + Regex.Escape(separator) + @"([A-Za-z]+)" + Regex.Escape(separator) + @".*?\s.*" + Regex.Escape(separator) + @"([A-Za-z]+)" + Regex.Escape(separator) + @".*?\s(\d):(\d)";

          //  Regex regex = new Regex(@".*" + Regex.Escape(separator) + @"([A-Za-z]*)" + Regex.Escape(separator) + @".*?\s.*" + Regex.Escape(separator) + @"([A-Za-z]*)" + Regex.Escape(separator) + @".*?\s(\d+):(\d+)");
            Regex regex = new Regex($@".*{Regex.Escape(separator)}([A-Za-z]*){Regex.Escape(separator)}.*?\s.*{Regex.Escape(separator)}([A-Za-z]*){Regex.Escape(separator)}.*?\s(\d+):(\d+)");
            
            string input = Console.ReadLine();
            Dictionary<string, int[]> table = new Dictionary<string, int[]>();

            while (!input.Equals("final"))
            {
                Match matches = regex.Match(input);//може да се наложи проверка дали има такъв във входа
                string firstTeamReversed = matches.Groups[1].ToString();
                string firstTeam = ReverseName(firstTeamReversed);

                string secondTeamReversed = matches.Groups[2].ToString();
                string secondTeam = ReverseName(secondTeamReversed);

                int firstTeamGoals = int.Parse(matches.Groups[3].ToString());
                int secondTeamGoals = int.Parse(matches.Groups[4].ToString());
                //int firstTeamPoints = 0;
                //int secondTeamPoints = 0;

                if (!table.ContainsKey(firstTeam))
                {
                    table[firstTeam] = new int[2];
                }

                if (!table.ContainsKey(secondTeam))
                {
                    table[secondTeam] = new int[2];
                }

                //List<int> fisrtTeamScores = new List<int>();
                //List<int> secondTeamScores = new List<int>();

                if (firstTeamGoals == secondTeamGoals)
                {
                    table[firstTeam][0] += 1;
                    table[firstTeam][1] += firstTeamGoals;
                    table[secondTeam][0] += 1;
                    table[secondTeam][1] += secondTeamGoals;
                }
                else if (firstTeamGoals > secondTeamGoals)
                {
                    table[firstTeam][0] += 3;
                    table[firstTeam][1] += firstTeamGoals;
                    table[secondTeam][1] += secondTeamGoals;
                }
                else
                {
                    table[firstTeam][1] += firstTeamGoals;
                    table[secondTeam][0] += 3;
                    table[secondTeam][1] += secondTeamGoals;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int numeration = 1;
            foreach (var teams in table.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{numeration}. {teams.Key} {teams.Value[0]}");
                numeration++;
            }

            Console.WriteLine("Top 3 scored goals:");

            //int count = 3;
            foreach (var item in table.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value[1]}");
                //count--;
                //if (count==0)
                //{
                //    break;
                //}
            }
        }

        private static string ReverseName(string firstTeamReversed)
        {
            char[] first = firstTeamReversed.ToCharArray();
            Array.Reverse(first);
            string firstTeam = new string(first);
            return firstTeam.ToUpper();
        }
    }
}
