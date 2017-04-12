using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        static void Main()
        {
            Dictionary<string, List<string>> participants = new Dictionary<string, List<string>>();
            bool isEmpty = true;

            char[] separators = new char[] { ',', ' ' };
            string[] names = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            string input = Console.ReadLine();

            while (!input.Equals("dawn"))
            {
                string[] tokens = input.Split(',').Select(x => x.Trim()).ToArray();
                string nameParticipant = tokens[0];
                string songOfParticipant = tokens[1];
                string award = tokens[2];

                if (names.Contains(nameParticipant) && songs.Contains(songOfParticipant))
                {
                    if (!participants.ContainsKey(nameParticipant))
                    {
                        participants[nameParticipant] = new List<string>();
                        isEmpty = false;
                    }
                    if (!participants[nameParticipant].Contains(award))
                    {
                        participants[nameParticipant].Add(award);
                    }
                    
                }


                input = Console.ReadLine();
            }

            if (isEmpty)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in participants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    long count = item.Value.Count();
                    Console.WriteLine("{0}: {1} awards", item.Key, count);

                    foreach (var award in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine("--{0}", award);
                    }
                }
            }
        }
    }
}