﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetni_Stepeni_Na_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = 0; i < n; i+=2)
            {
                Console.WriteLine(number);
                number *= 4;
            }
        }
    }
}
