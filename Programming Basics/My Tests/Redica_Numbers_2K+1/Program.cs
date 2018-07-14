using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redica_Numbers_2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = number; i < number; i++)
            {
                if (n >= number)

                {
                    Console.WriteLine(number);
                    number = number * 2 + 1;
                }
            }

        }
    }
}
