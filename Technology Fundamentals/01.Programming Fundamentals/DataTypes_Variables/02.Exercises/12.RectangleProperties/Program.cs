﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(width*2+height*2);
            Console.WriteLine(width*height);
            Console.WriteLine(Math.Sqrt(Math.Pow(width, 2)+Math.Pow(height,2)));

        }
    }
}
