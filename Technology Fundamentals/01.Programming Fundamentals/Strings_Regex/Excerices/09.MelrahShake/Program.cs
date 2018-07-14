using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            //StringBuilder finalText = new StringBuilder();

            int indexFirstMatch = text.IndexOf(pattern);
            int indexSecondMatch = text.LastIndexOf(pattern);


            while (indexFirstMatch > -1 && pattern.Length >= 1)
            {
                text = text.Remove(indexFirstMatch, pattern.Length);
                indexFirstMatch = text.IndexOf(pattern);
                indexSecondMatch = text.LastIndexOf(pattern);

                if (indexFirstMatch > -1)
                {
                    text = text.Remove(indexSecondMatch, pattern.Length);
                    indexFirstMatch = text.IndexOf(pattern);
                    indexSecondMatch = text.LastIndexOf(pattern);
                }

                Console.WriteLine("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);
                indexFirstMatch = text.IndexOf(pattern);
                indexSecondMatch = text.LastIndexOf(pattern);


            }
            Console.WriteLine("No shake.");

            Console.WriteLine(text);

        }
    }
}
