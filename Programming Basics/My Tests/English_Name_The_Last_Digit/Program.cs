using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string nameOfDigit = LastDigit(x);
            Console.WriteLine(nameOfDigit);
        }

        static string LastDigit(int number)
        {

            int lastDigitNumber = Math.Abs(number % 10); // tova e za otricatelni stoinosti na podadenoto chislo
            string digit = "";

            switch (lastDigitNumber)
            {
                case 0:
                    digit = "zero";
                    break;
                case 1:
                    digit = "one";
                    break;
                case 2:
                    digit = "two";
                    break;
                case 3:
                    digit = "three";
                    break;
                case 4:
                    digit = "four";
                    break;
                case 5:
                    digit = "five";
                    break;
                case 6:
                    digit = "six";
                    break;
                case 7:
                    digit = "seven";
                    break;
                case 8:
                    digit = "eight";
                    break;
                case 9:
                    digit = "nine";
                    break;
            }
            return digit;
        }

    }


}
