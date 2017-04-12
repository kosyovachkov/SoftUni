using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_To_Centimeters
{
    class Inches_To_Centimeters
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());

            var centimeters = n * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
