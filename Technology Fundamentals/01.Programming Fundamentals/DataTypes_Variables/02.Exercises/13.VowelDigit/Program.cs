using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input=="a"|| input == "e" || input == "o" || input == "u" || input == "i" )
            {
                Console.WriteLine("vowel");
            }

            else if (input == "0" || input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
            {
                Console.WriteLine("digit");
            }

            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
