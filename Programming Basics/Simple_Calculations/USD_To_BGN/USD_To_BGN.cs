﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_To_BGN
{
    class USD_To_BGN
    {
        static void Main(string[] args)
        {

            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.79549;

            Console.WriteLine("{0} BGN", Math.Round(bgn, 2));
        }
    }
}
