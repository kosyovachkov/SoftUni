using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                Console.Write("\\u" + ((int)item).ToString("x4"));
            }
            Console.WriteLine();
        }
    }
}
