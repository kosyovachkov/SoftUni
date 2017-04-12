using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double firstConverted = 0;

            if (input == "m")
            {
                firstConverted = number;
            }
            
            else if (input == "mm")
            {
                firstConverted = number / 1000;
            }

            else if (input == "cm")
            {
                firstConverted = number / 100;
            }

            else if (input == "mi")
            {
                firstConverted = number / 0.000621371192;
            }

            else if (input == "in")
            {
                firstConverted = number / 39.3700787;
            }

            else if (input == "km")
            {
                firstConverted = number / 0.001;
            }

            else if (input == "ft")
            {
                firstConverted = number / 3.2808399;
            }

            else if (input == "yd")
            {
                firstConverted = number / 1.0936133;
            }


            double secondConverted = 0;

            if (output == "m")
            {
                secondConverted = firstConverted;
            }
            
            else if (output == "mm")
            {
                secondConverted = firstConverted * 1000;
            }

            else if (output == "cm")
            {
                secondConverted = firstConverted * 100;
            }

            else if (output == "mi")
            {
                secondConverted = firstConverted * 0.000621371192;
            }

            else if (output == "in")
            {
                secondConverted = firstConverted * 39.3700787;
            }

            else if (output == "km")
            {
                secondConverted = firstConverted * 0.001;
            }

            else if (output == "ft")
            {
                secondConverted = firstConverted * 3.2808399;
            }

            else if (output == "yd")
            {
                secondConverted = firstConverted * 1.0936133;
            }

            Console.WriteLine("{0} {1}", secondConverted, output);
        }
    }
}
