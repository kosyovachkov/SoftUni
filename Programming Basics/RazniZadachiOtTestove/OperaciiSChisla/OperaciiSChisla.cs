using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaciiSChisla
{
    class OperaciiSChisla
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double result = 0;
            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }


            if (sign == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - odd");
                }
            }

            else if (sign == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - odd");
                }
            }

            else if (sign == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {sign} {n2} = {result} - odd");
                }
            }

            else if (sign == "/")
            {
                result = n1 / n2;
                Console.WriteLine($"{n1} {sign} {n2} = {result:f2}");
                
            }

            else
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} {sign} {n2} = {result}");
            }




        }
    }
}
