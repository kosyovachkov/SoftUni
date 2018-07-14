using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal finalSum = 0;

            foreach (var item in input)
            {
                decimal sum = Sum(item);

                finalSum += sum;
            }

            Console.WriteLine("{0:f2}", finalSum);
        }

        private static decimal Sum(string item)
        {
            char firstLetter = item[0];
            char secondLetter = item[item.Length - 1];
            int number = int.Parse(item.Substring(1, item.Length - 2));

            decimal tempSum = 0;
            decimal sum = 0;

            if (char.IsUpper(firstLetter))
            {
                tempSum = Divide(firstLetter, number);
            }
            if (char.IsLower(firstLetter))
            {
                tempSum = Multiply(firstLetter, number);
            }

            if (char.IsUpper(secondLetter))
            {
                sum += Substract(secondLetter, tempSum);
            }
            if (char.IsLower(secondLetter))
            {
                sum += Add(secondLetter, tempSum);
            }

            return sum;
        }

        private static decimal Add(char secondLetter, decimal tempSum)
        {
            int charPosition = secondLetter - 96;
            return tempSum + charPosition;
        }

        private static decimal Substract(char secondLetter, decimal tempSum)
        {
            int charPosition = secondLetter - 64;
            return tempSum - charPosition;
        }

        private static decimal Multiply(char firstLetter, decimal number)
        {
            int charPosition = firstLetter - 96;
            return number * charPosition;
        }

        private static decimal Divide(char firstLetter, decimal number)
        {
            int charPosition = firstLetter - 64;
            return  number / charPosition;
        }
    }
}
