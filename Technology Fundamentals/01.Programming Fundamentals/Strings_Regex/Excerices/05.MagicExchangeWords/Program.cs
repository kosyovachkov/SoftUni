using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string textOne = input[0];
            string textTwo = input[1];

            Dictionary<char, char> equalDoubles = new Dictionary<char, char>();
            bool isMagicWord = true;

            if (textOne.Length == textTwo.Length)
            {
                isMagicWord = CheckEqualParts(textOne, textTwo, equalDoubles);
            }

            else if (textOne.Length > textTwo.Length)// - може би тук по условие трябва да е false
            {
                isMagicWord = CheckEqualParts(textOne, textTwo, equalDoubles);
                isMagicWord = CheckRestPart(textOne, textTwo, equalDoubles);
            }

            else
            {
                isMagicWord = CheckEqualParts(textTwo, textOne, equalDoubles);
                isMagicWord = CheckRestPart(textTwo, textOne, equalDoubles);
            }

            Console.WriteLine(isMagicWord.ToString().ToLower());

        }

        private static bool CheckRestPart(string textOne, string textTwo, Dictionary<char, char> equalDoubles)
        {

            bool chekWord = true;

            for (int i = textTwo.Length; i < textOne.Length; i++)
            {
                if (!equalDoubles.ContainsValue(textOne[i]))
                {
                    chekWord = false;
                }
                else
                {
                    chekWord = true;
                }
            }

            return chekWord;
        }

        private static bool CheckEqualParts(string textOne, string textTwo, Dictionary<char, char> equalDoubles)
        {
            bool chekWord = true;

            int counter = Math.Min(textOne.Length, textTwo.Length);

            for (int i = 0; i < counter; i++)
            {
                if (!equalDoubles.ContainsKey(textOne[i]))
                {
                    equalDoubles.Add(textOne[i], textTwo[i]);
                }
                else
                {
                    if (equalDoubles[textOne[i]] != textTwo[i])
                    {
                        chekWord = false;
                        return chekWord;
                    }

                    else
                    {
                        chekWord = true;
                    }

                   
                }
            }
            return chekWord;
        }
    }
}