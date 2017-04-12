using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
        }
    }
}
