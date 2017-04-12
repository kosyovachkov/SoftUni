namespace WinningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class WinningTicket
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"@{6,10}|#{6,10}|\${6,10}|\^{6,10}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length < 20 || ticket.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string firstHalf = ticket.Substring(0, ticket.Length / 2);
                    string secondHalf = ticket.Substring(ticket.Length / 2);

                    Match fistMatch = regex.Match(firstHalf);
                    Match secondMatch = regex.Match(secondHalf);

                    if (fistMatch.Success && secondMatch.Success)
                    {
                        if (fistMatch.ToString()[0].Equals(secondMatch.ToString()[0]))
                        {
                            char winner = fistMatch.ToString()[0];

                            if (fistMatch.ToString().Length == 10 && fistMatch.ToString().Length == secondMatch.ToString().Length)
                            {
                                Console.WriteLine(@"ticket ""{0}"" - 10{1} Jackpot!", ticket, winner);
                            }

                            else if (fistMatch.ToString().Length <= secondMatch.ToString().Length)
                            {
                                int count = fistMatch.ToString().Length;
                                Console.WriteLine(@"ticket ""{0}"" - {1}{2}", ticket, count, winner);
                            }
                            else
                            {
                                int count = secondMatch.ToString().Length;
                                Console.WriteLine(@"ticket ""{0}"" - {1}{2}", ticket, count, winner);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(@"ticket ""{0}"" - no match", ticket);
                    }
                }
            }
        }
    }
}
