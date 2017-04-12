using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fisrtNumber = 1;
            int secondNumber = 1;
            int tempNumber = 0;

            for (int i = 0; i < n; i++)
            {
                tempNumber = fisrtNumber + secondNumber;
                fisrtNumber = secondNumber;
                secondNumber = tempNumber;
            }

            Console.WriteLine(fisrtNumber);
        }
    }
}
