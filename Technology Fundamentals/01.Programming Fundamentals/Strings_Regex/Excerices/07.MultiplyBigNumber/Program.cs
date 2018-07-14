using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == 0 || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            int product = 0;
            int numberInMind = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                product = (int)(int.Parse(firstNumber[i].ToString()) * secondNumber + numberInMind);
                numberInMind = (int)(product / 10);
                remainder = (int)(product % 10);
                result.Append(remainder);
                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }

            }

            char[] resultToCharArr = result.ToString().ToCharArray();
            Array.Reverse(resultToCharArr);
            Console.WriteLine(new string(resultToCharArr));
        }
    }
}
