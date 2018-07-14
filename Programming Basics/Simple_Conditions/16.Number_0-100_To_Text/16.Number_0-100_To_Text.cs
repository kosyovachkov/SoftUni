using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0_100_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


           
            if (n == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (n == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (n == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (n == 14)
            {
                Console.WriteLine("fourteen");
            }
            else if (n == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (n == 16)
            {
                Console.WriteLine("sixteen");
            }
            else if (n == 17)
            {
                Console.WriteLine("seventeen");
            }
            else if (n == 18)
            {
                Console.WriteLine("eighteen");
            }
            else if (n == 19)
            {
                Console.WriteLine("nineteen");
            }
            


            string first = "";
            string second = "";

            if (n / 10 == 2)
            {
                first = "twenty";
            }
            else if (n / 10 == 3)
            {
                first = "thirty";
            }
            else if (n / 10 == 4)
            {
                first = "fourty";
            }
            else if (n / 10 == 5)
            {
                first = "fifty";
            }
            else if (n / 10 == 6)
            {
                first = "sixty";
            }
            else if (n / 10 == 7)
            {
                first = "seventy";
            }
            else if (n / 10 == 8)
            {
                first = "eighty";
            }
            else if (n / 10 == 9)
            {
                first = "ninety";
            }

            if (n % 10 == 1)
            {
                second = "one";
            }
            else if (n % 10 == 2)
            {
                second = "two";
            }
            else if (n % 10 == 3)
            {
                second = "three";
            }
            else if (n % 10 == 4)
            {
                second = "four";
            }
            else if (n % 10 == 5)
            {
                second = "five";
            }
            else if (n % 10 == 6)
            {
                second = "six";
            }
            else if (n % 10 == 7)
            {
                second = "seven";
            }
            else if (n % 10 == 8)
            {
                second = "eight";
            }
            else if (n % 10 == 9)
            {
                second = "nine";
            }

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Invalid number");
            }
            else if (n == 0)
            {
                Console.WriteLine("zero");
            }
            else if (n == 10)
            {
                Console.WriteLine("ten");
            }
            else if (n == 100)
            {
                Console.WriteLine("one hundred");
            }

            else if (n % 10 == 0)
            {
                Console.WriteLine(first);
            }

            else if (n < 10)
            {
                Console.WriteLine(second);
            }

            else if (n >= 20 && n % 10 != 0)
            {
                Console.WriteLine("{0} {1}", first, second);
            }

        }
    }
}
