using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsSymetric(i) && SumOfDigits(i) && HasOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HasOneEvenDigit(int n)
        {
            while (n > 0)
            {
                int num = n % 10;
                n = n / 10;

                if (num % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool SumOfDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int num = n % 10;
                sum += num;
                n = n / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsSymetric(int n)
        {
            string text = n.ToString();
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}