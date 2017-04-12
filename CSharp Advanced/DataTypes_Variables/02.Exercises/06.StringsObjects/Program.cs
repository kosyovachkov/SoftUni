using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";
            string text2 = "World";

            object fullSentence = text + " " + text2;
            string sentence = fullSentence.ToString();

            Console.WriteLine(sentence);
        }
    }
}
