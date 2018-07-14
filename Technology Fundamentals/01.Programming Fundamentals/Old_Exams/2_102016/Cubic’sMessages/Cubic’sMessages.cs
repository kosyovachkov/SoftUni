namespace Cubic_sMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();

            // Dictionary<string, string> messages = new Dictionary<string, string>();

            while (!inputText.Equals("Over!"))
            {
                int count = int.Parse(Console.ReadLine());

                // Regex regex = new Regex(@"^(\d+)([A-Za-z]{" + count + @"})([^A-Za-z]*)$"); // все едно са два регекса и променливата между тях. Така се пъха променлива, когато ни потрябва.
                Regex regex = new Regex($@"^(\d+)([A-Za-z]{{{count}}})([^A-Za-z]*)$"); // Със $ преди @. Така се пъха променлива, когато ни потрябва.

                Regex number = new Regex(@"\d");

                string name = string.Empty;

                Match match = regex.Match(inputText);

                if (match.Success)
                {
                    name = match.Groups[2].ToString();

                    MatchCollection numbers = number.Matches(inputText);

                    List<int> nums = new List<int>();

                    foreach (Match matches in numbers)
                    {
                        nums.Add(int.Parse(matches.Value));
                    }

                    string decryptedMessage = string.Empty;


                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] >= 0 && nums[i] < name.Length)
                        {
                            decryptedMessage += name[nums[i]];
                        }

                        else
                        {
                            decryptedMessage += " ";
                        }
                    }

                    Console.WriteLine($"{name} == {decryptedMessage}");
                }

                inputText = Console.ReadLine();
            }
        }
    }
}
