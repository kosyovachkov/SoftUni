﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Numbers_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (100 <= number && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }

            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
