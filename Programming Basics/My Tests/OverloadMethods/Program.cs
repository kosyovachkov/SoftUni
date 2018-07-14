using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = input;
            PrintMessage(text, 5);
           
        }

        static void PrintMessage(string message, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(message);
            }
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
