namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
       public static void Main()
        {
            string input = Console.ReadLine();

            //Dictionary<string, string> messages = new Dictionary<string, string>();
            //Dictionary<string, string> broadcasts = new Dictionary<string, string>();

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            Regex regexMesage = new Regex(@"^(\d*)\s(<->)\s(\w*)$");
            Regex regexBroadcast = new Regex(@"^(\D*)\s(<->)\s(\w*)$");

            while (!input.Equals("Hornet is Green"))
            {
                Match matchMessage = regexMesage.Match(input);
                Match matchBroadcast = regexBroadcast.Match(input);

                if (matchMessage.Success)
                {
                    char[] code = matchMessage.Groups[1].Value.ToCharArray();
                    string message = matchMessage.Groups[3].Value.ToString();

                    Array.Reverse(code);
                    string reversedCode = new string(code);

                    string finalMessage = reversedCode + " -> " + message;
                    messages.Add(finalMessage);

                }

                else if (matchBroadcast.Success)
                {
                    string message = matchBroadcast.Groups[1].Value.ToString();
                    string frequency = matchBroadcast.Groups[3].Value.ToString();

                    string processFrequency = string.Empty;
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsUpper(frequency[i]))
                        {
                            processFrequency += char.ToLower(frequency[i], CultureInfo.InvariantCulture);
                        }
                        else if (char.IsLower(frequency[i]))
                        {
                            processFrequency += char.ToUpper(frequency[i], CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            processFrequency += frequency[i];
                        }
                    }

                    string finalBroadcast = processFrequency + " -> " + message;
                    broadcasts.Add(finalBroadcast);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count>0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count>0)
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
