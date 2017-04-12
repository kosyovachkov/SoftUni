using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string otherString = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(otherString);

            while (index>=0)
            {
                counter++;
                index = text.IndexOf(otherString, index + 1);
            }

            Console.WriteLine(counter);


            //Console.WriteLine("tralala".IndexOf("mama"));
        }
    }
}
