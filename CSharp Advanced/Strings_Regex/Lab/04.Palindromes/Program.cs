using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ', ',', '.', ':', '!', '?' };
            string[] text = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> finalText = new List<string>();

            foreach (var item in text)
            {

                bool isPalindrome = true;
                for (int i = 0; i < item.Length/2; i++)
                {
                    if (item[i]!=item[item.Length-1-i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    finalText.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", finalText.OrderBy(x =>x).Distinct()));
        }
    }
}
