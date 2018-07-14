using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ReplaceATag
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"<a.*?("".*?"")>(\w+)<\/a>";
            string replaced = "[URL href=$1]$2[/URL]";
            Regex regex = new Regex(pattern);

            while (!input.Equals("end"))
            {
                string newString = regex.Replace(input, replaced);

                Console.WriteLine(newString);

                input = Console.ReadLine();
            }

            


        }
    }
}
