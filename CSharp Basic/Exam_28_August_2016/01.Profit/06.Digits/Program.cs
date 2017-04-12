using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int newNumber = n;

            int firstNumber = newNumber / 100;
            int thirdNumber = newNumber % 10;
            newNumber = newNumber / 10;
            int secondNumber = newNumber % 10;

            for (int row = 1; row <= firstNumber + secondNumber; row++)
            {
                for (int col = 1; col <= firstNumber + thirdNumber; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstNumber;
                        Console.Write("{0} ", n);
                    }

                    else if (n % 3 == 0)
                    {
                        n -= secondNumber;
                        Console.Write("{0} ", n);
                    }

                    else
                    {
                        n += thirdNumber;
                        Console.Write("{0} ", n);
                    }
                }

                Console.WriteLine();
            }

        }
    }
}

//решена за 18.00
