using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= numbers; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }

                else
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }



            }

            if (numbers == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }


            else if (numbers == 1)
            {
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }

            else
            {
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum={0}", evenSum);
                Console.WriteLine("EvenMin={0}", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }


        }
    }
}
