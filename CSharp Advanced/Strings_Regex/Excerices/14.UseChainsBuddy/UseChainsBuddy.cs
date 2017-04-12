namespace _14.UseChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.IO;

    public class UseChainsBuddy
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string input = Console.ReadLine();

            Regex tagMatch = new Regex(@"(?<=(<p>))(.[^\/]+)(?=(<\/p>))");
            Regex spaces = new Regex(@"[^a-z0-9]+");

            MatchCollection matches = tagMatch.Matches(input);

            List<string> encrypted = new List<string>();

            foreach (Match item in matches)
            {
                string listInput = spaces.Replace(item.Value, " ");
                encrypted.Add(listInput);
            }

            List<string> decrypted = new List<string>();

            foreach (var item in encrypted)
            {
                string decryptedItem = DecryptedItem(item);
                decrypted.Add(decryptedItem);
            }

            foreach (var item in decrypted)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
        }

        private static string DecryptedItem(string item)
        {
            List<char> result = new List<char>();

            for (int i = 0; i < item.Length; i++)
            {
                if (item[i] == 32)
                {
                    result.Add(item[i]);
                }

                for (char j = 'a'; j < 'n'; j++)
                {
                    if (item[i] == j)
                    {
                        result.Add((char)(j + 13));
                        break;
                    }
                }

                for (char k = 'n'; k <= 'z'; k++)
                {
                    if (item[i] == k)
                    {
                        result.Add((char)(k - 13));
                        break;
                    }
                }

                for (int l = 0; l < 9; l++)
                {
                    if (item[i]==(char)48+l)
                    {
                        result.Add((char)(48+l));
                        break;
                    }
                }
            }

            return string.Join("", result).ToString();




            //// input
            //Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            //string html = Console.ReadLine();

            //// regex patterns
            //string pattern = @"<p>(.[^\/]+)<\/p>";
            //string regex = @"[^a-z0-9]+";

            //// logic - collecting the alpanumeric characters
            //Regex words = new Regex(pattern);
            //MatchCollection matches = words.Matches(html);
            //string encrypted = "";
            //for (int i = 0; i < matches.Count; i++)
            //{
            //    string temp = matches[i].Groups[1].Value;
            //    encrypted += Regex.Replace(temp, regex, word => " ");
            //}

            //// decrypting
            //string manual = "";
            //for (int i = 0; i < encrypted.Length; i++)
            //{
            //    if (encrypted[i] >= 'a' && encrypted[i] <= 'm')
            //    {
            //        manual += (char)(encrypted[i] + 13);
            //        //Console.WriteLine(manual);
            //    }
            //    else if (encrypted[i] >= 'n' && encrypted[i] <= 'z')
            //    {
            //        manual += (char)(encrypted[i] - 13);
            //    }
            //    else if (Char.IsDigit(encrypted[i]) || Char.IsWhiteSpace(encrypted[i]))
            //    {
            //        manual += encrypted[i];
            //    }
            //}
            //Console.WriteLine(manual);
        }
    }
}
